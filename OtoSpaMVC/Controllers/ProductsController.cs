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
//using OtoSpaMVC.Models.OtherHelperModels;
using Accord.MachineLearning.Rules;
using OtoSpaMVC.Models.OtherHelperModels;

namespace OtoSpaMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchString,
                     string currentFilter, int? page, string searchCategory, string sortOrder)

        {
            if (searchString != null)
            {
                page = 1;
            }

            int pageSize = 15;
            var products = GetProducts(searchString, currentFilter, searchCategory, sortOrder);
            var paginatedList = await PaginatedList<Product>.CreateAsync(products, page ?? 1, pageSize);
            if (GlobalFunctionality.IsAjaxRequest(Request))
            {
                return PartialView("_MultiProductTable", paginatedList);
            }
            return View(paginatedList);
        }

        [HttpGet]
        public IQueryable<Product> GetProducts(string searchString,
                                string currentFilter, string searchCategory, string sortOrder)
        {
            if (searchString == null)
            {
                searchString = currentFilter;
            }
            if (searchCategory == null)
            {
                searchCategory = ViewData["searchCategory"] as string;
            }
            var products = from s in _context.Product
                           select s;
            ViewData["CurrentFilter"] = searchString + "";
            ViewData["searchCategory"] = searchCategory + "";
            sortOrder = sortOrder ?? "name";

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.ProductName.Contains(searchString)// ||
                //p.ProductPrice.ToString().Equals(searchString) ||
                //p.ProductSuppliers.Where(pc => pc.Supplier.Name.Contains(searchString)).Count() != 0
                );
            }
            if (!String.IsNullOrEmpty(searchCategory))
            {
                products = products.Where(p => p.PrimaryCategory.Name.Contains(searchCategory)
                //p => p.ProductCategories.Where(pc => pc.Category.Name.Contains(searchCategory)).Count() != 0
                );
            }
            products = products.Include(p => p.PrimaryCategory).Include(r => r.ProductSuppliers).ThenInclude(rm => rm.Supplier);
            switch (sortOrder)
            {
                case "name":
                    products = products.OrderBy(s => s.ProductName);
                    ViewBag.TextSortOrder = "name";
                    break;
                case "name_desc":
                    products = products.OrderByDescending(s => s.ProductName);
                    ViewBag.TextSortOrder = "name";
                    break;
                case "price":
                    products = products.OrderBy(s => s.ProductPrice);
                    ViewBag.TextSortOrder = "price";
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.ProductPrice);
                    ViewBag.TextSortOrder = "price";
                    break;
            }
            ViewBag.SortOrder = sortOrder ?? "name";

            return (products.AsNoTracking());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.PrimaryCategory)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorize(Policy = "MustBeAdmin")]
        public IActionResult Create()
        {
            ViewData["categories"] = _context.Category
                          .Select(a => new SelectListItem()
                          {
                              Value = a.ID.ToString(),
                              Text = a.Name
                          })
                          .ToList();

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Create([Bind("ID,ProductName,ProductPrice,PrimaryCategory")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.Include(p=>p.PrimaryCategory).SingleOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,ProductPrice,PrimaryCategory")] Product product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
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
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .SingleOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.SingleOrDefaultAsync(m => m.ID == id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Policy = "MustBeAdmin")]
        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ID == id);
        }
        //// GET: Products/_AverageRating/1007
        ////private double getAverageRating(int? id) 
        //[Authorize(Policy = "MustBeAdmin")]
        //public async Task<IActionResult> _AverageRating(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var product = await _context.Product
        //        .SingleOrDefaultAsync(m => m.ID == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    var ratings = from r in _context.Rating
        //                  where r.ProductID == product.ID
        //                  group r by r.ProductID into rg
        //                  select rg;

        //    var avgRating = await ratings.Select(avg => new Rating
        //    {
        //        ProductRating = (int)avg.Average(rg => rg.ProductRating)
        //    }).SingleOrDefaultAsync();
            
        //    return View(avgRating);

        //}

        [HttpGet]
        public string[] _ShowAllCategories()
        {
            //// This code will show all categories flat, even those without products. (faster DB-op)
            //var categories = _context.Category.Select(c=>c.Name).ToArray();

            // (Old code, ignore)
            //var categories = _context.Product
            //    .SelectMany(p => p.ProductCategories.Select(pc => pc.Category))
            //    .GroupBy(c => c.Name).Select(g => g.Key).ToArray();

            // This is a demonstraition of Group-By capability, (Slower, but used due to project-demand)
            // and will only display categories for which products exist.
            var categories = _context.Product.Select(p => p.PrimaryCategory)
                .GroupBy(c => c.Name).Select(g => g.Key).ToArray();

            return categories;

        }
        // GET: Products
        public async Task<IActionResult> UserIndex(string searchString,
                                string currentFilter, int? page, string searchCategory, string sortOrder)
        {
            if (searchString != null)
            {
                page = 1;
            }

            int pageSize = 15;
            var products = GetProducts(searchString, currentFilter, searchCategory, sortOrder);
            var paginatedList = await PaginatedList<Product>.CreateAsync(products, page ?? 1, pageSize);
            if (GlobalFunctionality.IsAjaxRequest(Request))
            {
                return PartialView("_MultiProductTable", paginatedList);
            }
            return View(paginatedList);
        }

        [HttpGet]
        public async Task<IActionResult> _TopProducts(int? n)
        {
            int pageSize = (n ?? 3);

            var products = from p in _context.Product select p;
            var ratings = from r in _context.Rating select r;
            var ratingsgb = ratings.GroupBy(r => r.ProductID).Select(r => new bAverageRating
            {
                productID = r.Key,
                AvgRate = r.Average(d => d.ProductRating),
            });
            var listrat = ratingsgb.ToList();
            foreach (var p in products)
            {
                var fakerating = new bAverageRating
                {
                    productID = p.ID,
                    AvgRate = 0,
                };
                listrat.Add(fakerating);
            }
            products = products.Join(listrat, p => p.ID, r => r.productID,
                (p, r) => new { p, r }).OrderByDescending(a => a.r.AvgRate).Select(b => b.p);

            //n = (n == null) ? n : 4;
            var tops = products.Take(n ?? 3);

            var paginatedList = await PaginatedList<Product>.CreateAsync(tops, 1, pageSize);
            if (GlobalFunctionality.IsAjaxRequest(Request))
            {
                return PartialView("_MultiProductTable", paginatedList);
            }
            return View(paginatedList);
        }


        //--------------------// /// Machine LEARNING /// //--------------------//

        [HttpGet]
        [Authorize(Policy = "MustBeUser")]
        public async Task<IActionResult> ForYou()
        {
            var UserID = Services.GlobalFunctionality.GetCurrentUserID(HttpContext);
            var matches = CustomMatches(UserID);

            ViewData["ForUser"] = matches;
            return View(matches);
            //var applicationDbContext = _context.Product.Include(c => c.).Include(c => c.Product);
            //return View(await matches.ToListAsync());
        }

        // Example from https://en.wikipedia.org/wiki/Apriori_algorithm

        // Assume that a large supermarket tracks sales data by stock-keeping unit
        // (SKU) for each item: each item, such as "butter" or "bread", is identified 
        // by a numerical SKU. The supermarket has a database of transactions where each
        // transaction is a set of SKUs that were bought together.


        //// Let the database of transactions consist of following itemsets:
//      //private AssociationRuleMatcher<PurchaseItem> LearnPurchases()  /** TIMED FUNCTION **/
        //{
        //    PurchaseItem[][] purchaseVectors =
        //        _context.Purchase.Include(p => p.Items).Select(p => p.Items.ToArray()).ToArray();

        //    //var map = purchaseVectors.Select(delegate (ICollection<PurchaseItem> vector)
        //    //{
        //    //    return vector.AsQueryable().Select(v => v.ProductID).ToArray();
        //    //}).ToArray();
        //    var map = purchaseVectors;

        //    // SortedSet<int>[] dataset = categories2;
        //    //        {
        //    //// Each row represents a set of items that have been bought 
        //    //// together. Each number is a SKU identifier for a product.
        //    //new SortedSet<int> { 1, 2, 3, 4 }, // bought 4 items
        //    //new SortedSet<int> { 1, 2, 4 },    // bought 3 items
        //    //new SortedSet<int> { 1, 2 },       // bought 2 items
        //    //new SortedSet<int> { 2, 3, 4 },    // ...
        //    //new SortedSet<int> { 2, 3 },
        //    //new SortedSet<int> { 3, 4 },
        //    //new SortedSet<int> { 2, 4 },
        //    //        };

        //    // We will use Apriori to determine the frequent item sets of this database.
        //    // To do this, we will say that an item set is frequent if it appears in at 
        //    // least 3 transactions of the database: the value 3 is the support threshold.

        //    // Create a new a-priori learning algorithm with support 3
        //    Apriori<PurchaseItem> apriori =
        //        new Apriori<PurchaseItem>(
        //            threshold: 1, confidence: 0);

        //    // Use the algorithm to learn a set matcher
        //    AssociationRuleMatcher<PurchaseItem> classifier = apriori.Learn(map);
        //    return classifier;
        //}

        private Product[][] CustomMatches(string UserID)
        {
            AssociationRuleMatcher<hAprioriData> classifier =
                new hAprioriClassifier(_context).getClassifier();

            // naieve - last order
            PurchaseItem[] lastPurchase = _context.Purchase.
                Where(p => p.UserID == UserID).
                OrderBy(p => p.PurchaseDate).
                LastOrDefault().Items.ToArray();
            var helper = hAprioriFunctionality.wrapProductsItems(lastPurchase);

            // Use the classifier to find orders that are similar to 
            // the last ordered items this client made:
            PurchaseItem[][] modelResult = classifier.Decide(helper);
            Product[][] matches = hAprioriFunctionality.extractProducts(modelResult);

            return matches;

            // The result should be:
            // 
            //   new int[][]
            //   {
            //       new int[] { 4 },
            //       new int[] { 3 }
            //   };

            // Meaning the most likely product to go alongside the products
            // being bought is item 4, and the second most likely is item 3.

            // We can also obtain the association rules from frequent itemsets:
            //        { { { { { } } } } }
            //        AssociationRule<int>[] rules = classifier.Rules;


            //    public AssociationRuleMatcher<int> Classifier { get => Classifier1; set => Classifier1 = value; }
            //    public AssociationRuleMatcher<int> Classifier1 { get => classifier; set => classifier = value; }
            //    public AssociationRuleMatcher<int> Classifier2 { get => classifier; set => classifier = value; }
            //} }}}}}
            // The result will be:
            // {
            //     [1] -> [2]; support: 3, confidence: 1, 
            //     [2] -> [1]; support: 3, confidence: 0.5, 
            //     [2] -> [3]; support: 3, confidence: 0.5, 
            //     [3] -> [2]; support: 3, confidence: 0.75, 
            //     [2] -> [4]; support: 4, confidence: 0.66, 
            //     [4] -> [2]; support: 4, confidence: 0.8, 
            //     [3] -> [4]; support: 3, confidence: 0.75, 
            //     [4] -> [3]; support: 3, confidence: 0.6 
            // };
        }

    }
}

