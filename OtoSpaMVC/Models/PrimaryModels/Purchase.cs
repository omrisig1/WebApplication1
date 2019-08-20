using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OtoSpaMVC.Models
{
    [DisplayName("Purchase")]
    public class Purchase
    {
        [DisplayName("Purchase ID")]
        public int ID { get; set; }
        
	    //[DisplayName("Cart ID")]
	    //public int CartID { get; set; }

		//[DisplayName("Purchase Cart")]
		//[ForeignKey(nameof(CartID))]
  //      public Cart PurchaseCart { get; set; }

		[DisplayName("User ID (string)")]
	    public string UserID { get; set; }

		[DisplayName("Purchase User")]
		[ForeignKey(nameof(UserID))]
        public ApplicationUser User { get; set; }

        // can be another model PaymentDetails.cs
        [DisplayName("Purchase Credit Details")]
        public string CreditDetails { get; set; }

        [DisplayName("Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Total Price")]
        public double Total { get; set; }

        [Display(Name = "Items Bought")]
        public ICollection<PurchaseItem> Items { get; set; }
    }
}
