using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OtoSpaMVC.Models
{
    [DisplayName("Item In Purchase")]
    public class PurchaseItem
    {
        [DisplayName("Item ID")]
        public int ID { get; set; }

		[DisplayName("Product ID")]
		public int ProductID { get; set; }

		[DisplayName("Product")]
		[ForeignKey(nameof(ProductID))]
	    public Product Product { get; set; }

		[DisplayName("Amount")]
        public int Amount { get; set; }

	    [DisplayName("Purchase ID")]
	    public int PurchaseID { get; set; }

		[DisplayName("Purchase (Parent)")]
		[ForeignKey(nameof(PurchaseID))]
        public Purchase Purchase { get; set; }

	}
}
