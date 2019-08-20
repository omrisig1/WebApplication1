using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OtoSpaMVC.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
	    // [InverseProperty(nameof(Rating.User))]
		public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
		// purchese history
    }
}
