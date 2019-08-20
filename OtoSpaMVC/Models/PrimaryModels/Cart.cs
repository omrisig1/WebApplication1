using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace OtoSpaMVC.Models
{
    [DisplayName("Cart")]
    public class Cart
    {
        [Key]
        [Display(Name = "Cart ID")]
        public int ID { get; set; }

	    [Display(Name = "User ID (string)")]
	    public string UserID { get; set; }

	    [Display(Name = "User")]
	    [ForeignKey(nameof(UserID))]
		public ApplicationUser User { get; set; }

        //public Dictionary<Product, int> products { get; set; }
        [Display(Name = "Products in Cart")]
        public ICollection<CartItem> Items { get; set; }

        [Display(Name = "Total")]
        public int Total { get; set; }

        // should not be showen in user dialogs, internal use
        [Display(Name = "Is Cart Editable")]
        public Boolean Editable { get; set; }
    }
}
