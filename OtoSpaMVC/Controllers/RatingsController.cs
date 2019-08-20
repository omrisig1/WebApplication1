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

namespace OtoSpaMVC.Controllers
{
    public class RatingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ratings
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var ratings = from r in _context.Rating select r;
            ratings=ratings.Include(r => r.Product).Include(r => r.User);

            if (!String.IsNullOrEmpty(searchString))
            {
                ratings = ratings.Where(r => r.Product.ProductName.Contains(searchString)||r.User.UserName.Contains(searchString));
            }
            return View(await ratings.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> TopRating()
        {


            var ratings = from r in _context.Rating select r;
            ratings.OrderByDescending(x => x.ProductRating).Take(4);
            ratings = ratings.Include(r => r.Product).ThenInclude(r => r.URIImage).Include(r=>r.Product.ProductPrice);


            return View(await ratings.AsNoTracking().ToListAsync());
        }

        // GET: Ratings/Details/5 
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating
                .Include(r => r.Product)
                .Include(r => r.User)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // GET: Ratings/Create
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID");
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Ratings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductRating,ProductID,UserID")] Rating rating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", rating.ProductID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", rating.UserID);
            return View(rating);
        }

        // GET: Ratings/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating.SingleOrDefaultAsync(m => m.ID == id);
            if (rating == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", rating.ProductID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", rating.UserID);
            return View(rating);
        }

        // POST: Ratings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductRating,ProductID,UserID")] Rating rating)
        {
            if (id != rating.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingExists(rating.ID))
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
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", rating.ProductID);
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", rating.UserID);
            return View(rating);
        }

        // GET: Ratings/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating
                .Include(r => r.Product)
                .Include(r => r.User)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // POST: Ratings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rating = await _context.Rating.SingleOrDefaultAsync(m => m.ID == id);
            _context.Rating.Remove(rating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RatingExists(int id)
        {
            return _context.Rating.Any(e => e.ID == id);
        }

        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Graph() => View();
        //{
        //    //var products = from p in _context.Product select p;
        //    //products = products.Include(p => p.ProductRatings).Include(p => p.PrimaryCategory);
        //    ////products = products.Include(p => p.ProductCategories).ThenInclude(pc => pc.GetEnumerator().Current.Category);

        //    //Graphload();
        //    return View();
        //}

        [HttpGet]
        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Graphload()
        {
            if (!GlobalFunctionality.IsAjaxRequest(Request))
                return new EmptyResult();

            var products = from p in _context.Product select p;
            products = products
                .Include(p => p.PrimaryCategory)
                .Include(p => p.ProductRatings).DefaultIfEmpty();

            var pie = products.Select(p => new bProductsRatings {
                product = p,
                ratings = p.ProductRatings,
                stars = new int[0]
            });

            //ViewData["ProductRaringsPie"] = pie;
            return PartialView("_blobToCsv", pie.ToList());
        }

    }
}
