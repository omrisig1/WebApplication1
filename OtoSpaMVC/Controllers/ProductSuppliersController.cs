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

namespace OtoSpaMVC.Controllers
{
    public class ProductSuppliersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductSuppliersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductSuppliers
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProductSupplier.Include(p => p.Product).Include(p => p.Supplier);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProductSuppliers/Details/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSupplier = await _context.ProductSupplier
                .Include(p => p.Product)
                .Include(p => p.Supplier)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (productSupplier == null)
            {
                return NotFound();
            }

            return View(productSupplier);
        }

        // GET: ProductSuppliers/Create
        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Create()
        {
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID");
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "ID", "ID");
            return View();
        }

        // POST: ProductSuppliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Create([Bind("ID,SupplierID,ProductID")] ProductSupplier productSupplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productSupplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", productSupplier.ProductID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "ID", "ID", productSupplier.SupplierID);
            return View(productSupplier);
        }

        // GET: ProductSuppliers/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSupplier = await _context.ProductSupplier.SingleOrDefaultAsync(m => m.ID == id);
            if (productSupplier == null)
            {
                return NotFound();
            }
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", productSupplier.ProductID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "ID", "ID", productSupplier.SupplierID);
            return View(productSupplier);
        }

        // POST: ProductSuppliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SupplierID,ProductID")] ProductSupplier productSupplier)
        {
            if (id != productSupplier.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productSupplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductSupplierExists(productSupplier.ID))
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
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", productSupplier.ProductID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "ID", "ID", productSupplier.SupplierID);
            return View(productSupplier);
        }

        // GET: ProductSuppliers/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSupplier = await _context.ProductSupplier
                .Include(p => p.Product)
                .Include(p => p.Supplier)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (productSupplier == null)
            {
                return NotFound();
            }

            return View(productSupplier);
        }

        // POST: ProductSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productSupplier = await _context.ProductSupplier.SingleOrDefaultAsync(m => m.ID == id);
            _context.ProductSupplier.Remove(productSupplier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductSupplierExists(int id)
        {
            return _context.ProductSupplier.Any(e => e.ID == id);
        }
    }
}
