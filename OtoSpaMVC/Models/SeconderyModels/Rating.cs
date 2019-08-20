using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    [DisplayName("Rating")]
    public class Rating
    {
        [DisplayName("Rating Id")]
        public int ID { get; set; }

        [DisplayName("Rating")]
        [Range(0, 5,ErrorMessage = "Price must be between 0 and 5")]
        public int ProductRating { get; set; }
        
        //[Key]
        [DisplayName("Product Id")]
        public int ProductID { get; set; }

        [DisplayName("Rating Product")]
        [ForeignKey(nameof(ProductID))]
		public virtual Product Product { get; set; }

        //[Key]
        [Display(Name = "User ID (string)")]
	    public string UserID { get; set; }

	    [Display(Name = "User")]
		[ForeignKey(nameof(UserID))]
	    public ApplicationUser User { get; set; }

	}
}
