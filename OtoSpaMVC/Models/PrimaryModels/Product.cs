using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace OtoSpaMVC.Models
{
    [DisplayName("Product")]
    public class Product
    {
        [DisplayName("Product Id")]
        public int ID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName  { get; set; }

        [DisplayName("Product Price")]
        public double ProductPrice { get; set; }

        [DisplayName("Product Ratings")]
        // [InverseProperty(nameof(Rating.Product))]
		public virtual ICollection<Rating> ProductRatings { get; set; }

        [DisplayName("Product Image")]
        public string URIImage { get; set; }

        [DisplayName("Primary-Category ID")]
        public int PrimaryCategoryID { get; set; }

        [DisplayName("Product Category")]
        [ForeignKey(nameof(PrimaryCategoryID))]
        public Category PrimaryCategory { get; set; }
        
        //        [DisplayName("Product Categories")]
        //        // [InverseProperty(nameof(ProductCategory.Product))]
        //		public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        [DisplayName("Product Suppliers")]
		// [InverseProperty(nameof(ProductSupplier.Product))]	//[InverseProperty("Product")]
		public virtual ICollection<ProductSupplier> ProductSuppliers { get; set; }
	}
}
