using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    [DisplayName("Supplier")]
    public class Supplier
    {
        [Display(Name = "Supplier Id")]
        public int ID { get; set; }

        [Display(Name = "Supplier Name")]
        public string Name { get; set; }

        [Display(Name = "Supplier ContactUs")]
        public string Contact { get; set; }

        [Phone]
        [Display(Name = "Supplier Phone")]
        public string Phone { get; set; }

        [EmailAddress]
        [Display(Name = "Supplier Email")]
        public string Email { get; set; }

        [Display(Name = "Supplier Address")]
        public string Address { get; set; }

        [Url]
        [Display(Name = "Supplier Website")]
        public string Website { get; set; }

	    [Display(Name = "Products")]
	    // [InverseProperty(nameof(ProductSupplier.Supplier))]
		public virtual ICollection<ProductSupplier> Products { get; set; }

	}
}
