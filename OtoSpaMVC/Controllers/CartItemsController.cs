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
    public class CartItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CartItems
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CartItem.Include(c => c.Cart).Include(c => c.Product);
            var cartItems = applicationDbContext
           .GroupBy(jj => jj.ProductID)
           .Select(g => new CartItem
           { 
               Product = g.First().Product,
               Amount = g.First().Amount,
               Cart = g.First().Cart,
               CartID = g.First().CartID,
               ProductID = g.Key,
               Counter = g.Count()
           }).ToList();

            return  View(cartItems);
        }






        // GET: CartItems/Details/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem
                .Include(c => c.Cart)
                .Include(c => c.Product)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // GET: CartItems/Create
        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Create()
        {
            ViewData["CartID"] = new SelectList(_context.Set<Cart>(), "ID", "ID");
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID");
            return View();
        }

        // POST: CartItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Create([Bind("ID,ProductID,Amount,CartID")] CartItem cartItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CartID"] = new SelectList(_context.Set<Cart>(), "ID", "ID", cartItem.CartID);
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", cartItem.ProductID);
            return View(cartItem);
        }

        // GET: CartItems/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem.SingleOrDefaultAsync(m => m.ID == id);
            if (cartItem == null)
            {
                return NotFound();
            }
            ViewData["CartID"] = new SelectList(_context.Set<Cart>(), "ID", "ID", cartItem.CartID);
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", cartItem.ProductID);
            return View(cartItem);
        }

        // POST: CartItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductID,Amount,CartID")] CartItem cartItem)
        {
            if (id != cartItem.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemExists(cartItem.ID))
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
            ViewData["CartID"] = new SelectList(_context.Set<Cart>(), "ID", "ID", cartItem.CartID);
            ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID", cartItem.ProductID);
            return View(cartItem);
        }

        // GET: CartItems/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem
                .Include(c => c.Cart)
                .Include(c => c.Product)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartItem = await _context.CartItem.SingleOrDefaultAsync(m => m.ID == id);
            _context.CartItem.Remove(cartItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItem.Any(e => e.ID == id);
        }
        
    }

}
