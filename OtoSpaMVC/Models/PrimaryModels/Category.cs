using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    [DisplayName("Category")]
    public class Category
    {
        [Display(Name = "Category ID")]
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        public string Name { get; set; }

  //		// [InverseProperty(nameof(ProductCategory.Product))]
  //      [Display(Name = "Category Products")]
  //      public virtual ICollection<ProductCategory> Products { get; set; }
    }
}
