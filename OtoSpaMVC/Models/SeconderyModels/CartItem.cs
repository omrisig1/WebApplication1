using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OtoSpaMVC.Models
{
    [DisplayName("Item In Cart")]
    public class CartItem
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

	    [DisplayName("Cart ID")]
	    public int CartID { get; set; }

		[DisplayName("Cart (Parent)")]
		[ForeignKey(nameof(CartID))]
        public Cart Cart { get; set; }

        [NotMapped]
        public int Counter { get; set; }

	}
}
