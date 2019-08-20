using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    public class bPurchasedProducts
    {
        public Product product { get; set; }
        public Category category { get; set; }
        public IEnumerable<PurchaseItem> itemsGroup { get; set; }
        public int purchaseCount { get; set; }
        public int totalAmount { get; set; }
    }
}
