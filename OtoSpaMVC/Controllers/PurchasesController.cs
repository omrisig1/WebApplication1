using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;
using OtoSpaMVC.Services;

namespace OtoSpaMVC.Views.Purchases
{
    public class PurchasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Purchases
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Purchase.Include(p => p.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Purchases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchase
                .Include(p => p.User).Include(p=>p.Items).ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // GET: Purchases/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,CreditDetails")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", purchase.UserID);
            return View(purchase);
        }

        // GET: Purchases/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchase.FindAsync(id);
            if (purchase == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", purchase.UserID);
            return View(purchase);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,CreditDetails")] Purchase purchase)
        {
            if (id != purchase.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseExists(purchase.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", purchase.UserID);
            return View(purchase);
        }

        // GET: Purchases/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchase = await _context.Purchase
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (purchase == null)
            {
                return NotFound();
            }

            return View(purchase);
        }

        // POST: Purchases/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchase = await _context.Purchase.FindAsync(id);
            _context.Purchase.Remove(purchase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Policy = "MustBeAdmin")]
        private bool PurchaseExists(int id)
        {
            return _context.Purchase.Any(e => e.ID == id);
        }

        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Graph() => View();
        //{
        //    //var allProducts =
        //    //    _context.Product.Include(x => x.PrimaryCategory);
        //    //List<string> csv = new List<string>();
        //    //ViewData["RatingsData"] = csv;

        //    //Graphload();
        //    return View();
        //}

        [HttpGet]
        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Graphload()
        {
            if (!GlobalFunctionality.IsAjaxRequest(Request))
                return new EmptyResult();

            var groupedData =
                from prod in _context.Product
                join item in _context.PurchaseItem
                on prod.ID equals item.ProductID
                into itemsGroup
                select new bPurchasedProducts
                {
                    product = prod,
                    itemsGroup = itemsGroup,
                    category = prod.PrimaryCategory,
                    purchaseCount = itemsGroup.Count(),
                    totalAmount = itemsGroup.Sum(i => i.Amount)
                };

            //ViewData["gd"] = groupedData.ToList();
            return PartialView("_blobToCsv", groupedData.ToList());
        }

        public async Task<IActionResult> PreviousPurc()
        {
            var UserID =GlobalFunctionality.GetCurrentUserID(HttpContext);
            //var viewP = _context.Purchase.Where(c => c.UserID == UserID).Include(p => p.User).Include(p => p.Items) ;
            var viewP =_context.Purchase.Include(p => p.User).Include(p => p.Items).ThenInclude(ci => ci.Product).Where(c => c.UserID == UserID);
            return View(await viewP.ToListAsync());
        }
    }
}
