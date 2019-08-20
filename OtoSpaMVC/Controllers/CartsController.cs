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
using OtoSpaMVC.Views.Purchases;

namespace OtoSpaMVC.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Carts
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cart.Include(c => c.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Carts/Details/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .Include(c => c.User)
                .Include(c=> c.Items).ThenInclude(ci=>ci.Product)//.ThenInclude(c=>c.ProductName)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Create([Bind("ID,UserID,Total,Editable")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", cart.UserID);
            return View(cart);
        }

        // GET: Carts/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart.SingleOrDefaultAsync(m => m.ID == id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", cart.UserID);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,Total,Editable")] Cart cart)
        {
            if (id != cart.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.ID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", cart.UserID);
            return View(cart);
        }

        // GET: Carts/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .Include(c => c.User)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Cart.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool CartExists(int id)
        {
            return _context.Cart.Any(e => e.ID == id);
        }

        //[Authorize(Policy = "MustBeUser")]
        public IActionResult MyCartDetails()
        {
            var UserID = Services.GlobalFunctionality.GetCurrentUserID(HttpContext);
            if (UserID == null || UserID.Length == 0)
            {
                ViewData["Title"] = "You must be a registered user to buy.";
                return View("PleaseJoin");
            }
            Cart cart = GetUsersCart(UserID);
            //if (cart == null)
            //    return view( "somethingWentWrongSorry" );
            return View(cart);
        }

        private Cart GetUsersCart(string prmUserID)
        {
            Cart cart = RetrieveExistingCart(prmUserID);
            if (cart == null) {
                cart = new Cart { UserID = prmUserID, Editable = true };
                _context.Add(cart);
                _context.SaveChanges();     // mustn't be Async for next line to work!
                cart = RetrieveExistingCart(prmUserID);
            }
            return cart;
        }

        [Authorize(Policy = "MustBeAdmin")]
        private Cart RetrieveExistingCart(string prmUserID)
        {
            return _context.Cart
                .Include(c => c.User)
                .Include(c => c.Items).ThenInclude(ci => ci.Product)
                .SingleOrDefault(m => m.UserID.Equals(prmUserID) && m.Editable == true);
        }

        public IActionResult AddProductToCart(int cartid, int productid,int amount, string returnUrl = null)
        {// TODO call AddProductToCart without leaving the page
            
            if (amount != 0)
            {
                var cart =  _context.Cart
                .Include(c => c.User)
                .Include(c => c.Items).ThenInclude(ci => ci.Product)
                .SingleOrDefault(m => m.ID== cartid && m.Editable == true);
                if (cart==null)
                {
                    ////think on someting
                }
                var cartitems= cart.Items.Where(ci => ci.ProductID == productid);
                CartItem cartitem=null;
                if (cartitems.Count() != 0)
                {
                    if (cartitems.Count() == 1)
                    {
                        cartitem = cartitems.SingleOrDefault();
                    }
                    else
                    {
                        cartitem = cartitems.First();
                        cartitem.Amount = 0;
                        foreach (var ci in cartitems)
                        {
                            cartitem.Amount += ci.Amount;
                            _context.CartItem.Remove(ci);
                        }
                        _context.SaveChanges();
                        _context.CartItem.Add(cartitem);
                        _context.SaveChanges();
                    }
                }
                if (cartitem == null)
                {
                    if (amount <= 0)
                        return RedirectToLocal(returnUrl);
                    cartitem = new CartItem
                    {
                        CartID = cartid,
                        ProductID = productid,
                        Amount = 0
                    };
                    _context.CartItem.Add(cartitem);
                    _context.SaveChanges();
                }
                cartitem.Amount += amount;
                if (cartitem.Amount <= 0)
                {
                    _context.CartItem.Remove(cartitem);
                }
                else
                {
                    _context.CartItem.Update(cartitem);
                }
                _context.SaveChanges();
            }
            return RedirectToLocal(returnUrl);

        }

        [HttpGet]
        public IActionResult AddProductToCart1(int productid, int amount, string returnUrl = null)
        {// TODO call AddProductToCart1 without leaving the page
            //ApplicationUser applicationUser = _context.Users.SingleOrDefault(ua => ua.UserName.Equals(User.Identity.Name));
            //if (applicationUser == null)
            var UserID = Services.GlobalFunctionality.GetCurrentUserID(HttpContext);
            if (UserID == null || UserID.Length == 0)
            {
                ViewBag.TextErrorNotLoggedIn = "You are not login3";
                return View("PleaseJoin");
            }

            var cart = _context.Cart
            .SingleOrDefault(m => m.UserID.Equals(UserID) && m.Editable == true);
            if (cart == null)
            {
                return View("PleaseJoin");
            }
            return AddProductToCart(cart.ID, productid, amount, returnUrl);
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(CartsController.MyCartDetails), "Carts");
            }
        }
        [Authorize(Policy = "MustBeUser")]
        public IActionResult MakePurchase(int cartid)
        {
            Cart cart = _context.Cart.Include(c => c.Items).ThenInclude(ci=>ci.Product)
                .SingleOrDefault(c => c.ID == cartid && c.Editable == true);
            if (cart == null)
                return NotFound();
            if (cart.Items == null || cart.Items.Count == 0)
                return View("error");       // todo: ErrorCartEmpty

            cart.Editable = false;
            _context.Update(cart);
            Purchase purchase = new Purchase()
            {
                UserID = cart.UserID, CreditDetails = "", Items = new LinkedList<PurchaseItem>(), Total = 0,
                PurchaseDate = DateTime.Now
            };

            _context.Purchase.Add(purchase);
            _context.SaveChanges();
            var sum = 0.0;
            foreach (var item in cart.Items)
            {
                _context.PurchaseItem.Add(new PurchaseItem
                {
                    ProductID = item.ProductID,
                    Amount = item.Amount,
                    PurchaseID = purchase.ID,
                });
                double ProductPrice = item.Product.ProductPrice;
                int Amount = item.Amount;
                sum += (ProductPrice* Amount);
            }
            purchase.Total = sum;
            //purchase.Items.Add(
            //    new PurchaseItem {
            //        ProductID = item.ProductID,
            //        Product = item.Product,
            //        Amount = item.Amount,
            //        PurchaseID = purchase.ID,
            //        Purchase = purchase
            //    }
            //);

            _context.Purchase.Update(purchase);

            _context.SaveChanges();
            Purchase purchaseSaved = _context.Purchase.Where(p => p.ID == purchase.ID).SingleOrDefault();
            if (purchaseSaved == null) {
                return View("error");       // todo: Sorry, server error.
            }
            // OKKK
            _context.Remove(cart);

            //return RedirectToAction(nameof(HomeController.Index), "Home");
            return RedirectToAction(nameof(PurchasesController.Details), "Purchases", new { ID = purchase.ID });
        }
    }
}
