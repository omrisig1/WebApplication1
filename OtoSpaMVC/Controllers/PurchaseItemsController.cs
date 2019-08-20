using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Data;
using OtoSpaMVC.Models;

namespace OtoSpaMVC.Controllers
{
    public class PurchaseItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchaseItems
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PurchaseItem.Include(p => p.Product).Include(p => p.Purchase);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PurchaseItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseItem = await _context.PurchaseItem
                .Include(p => p.Product)
                .Include(p => p.Purchase)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (purchaseItem == null)
            {
                return NotFound();
            }

            return View(purchaseItem);
        }

        // GET: PurchaseItems/Create
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID");
            ViewData["PurchaseID"] = new SelectList(_context.Purchase, "ID", "ID");
            return View();
        }

        // POST: PurchaseItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductID,Amount,PurchaseID")] PurchaseItem purchaseItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", purchaseItem.ProductID);
            ViewData["PurchaseID"] = new SelectList(_context.Purchase, "ID", "ID", purchaseItem.PurchaseID);
            return View(purchaseItem);
        }

        // GET: PurchaseItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseItem = await _context.PurchaseItem.FindAsync(id);
            if (purchaseItem == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", purchaseItem.ProductID);
            ViewData["PurchaseID"] = new SelectList(_context.Purchase, "ID", "ID", purchaseItem.PurchaseID);
            return View(purchaseItem);
        }

        // POST: PurchaseItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductID,Amount,PurchaseID")] PurchaseItem purchaseItem)
        {
            if (id != purchaseItem.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseItemExists(purchaseItem.ID))
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
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", purchaseItem.ProductID);
            ViewData["PurchaseID"] = new SelectList(_context.Purchase, "ID", "ID", purchaseItem.PurchaseID);
            return View(purchaseItem);
        }

        // GET: PurchaseItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseItem = await _context.PurchaseItem
                .Include(p => p.Product)
                .Include(p => p.Purchase)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (purchaseItem == null)
            {
                return NotFound();
            }

            return View(purchaseItem);
        }

        // POST: PurchaseItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseItem = await _context.PurchaseItem.FindAsync(id);
            _context.PurchaseItem.Remove(purchaseItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseItemExists(int id)
        {
            return _context.PurchaseItem.Any(e => e.ID == id);
        }
    }
}
