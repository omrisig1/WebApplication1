using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OtoSpaMVC.Models.OtherHelperModels
{
    public class hAprioriData : PurchaseItem, IComparable<PurchaseItem>
    {
        public hAprioriData(PurchaseItem item)
        {
            this.ProductID = item.ProductID;
            this.PurchaseID = item.PurchaseID;
            this.Amount = item.Amount;
        }

        public int CompareTo(PurchaseItem other)
        {
            int comp = 0;

            try {
                comp = this.Product.ProductPrice.CompareTo(other.Product.ProductPrice);
                if (comp != 0)
                    return comp;

                comp = this.Amount.CompareTo(other.Amount);
                if (comp != 0)
                    return comp;

                comp = this.ProductID.CompareTo(other.ProductID);
                if (comp != 0)
                    return comp;

            } catch (NullReferenceException) {}

            return comp;
        }

        //// GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
