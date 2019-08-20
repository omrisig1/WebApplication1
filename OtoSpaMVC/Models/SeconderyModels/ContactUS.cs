using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    [DisplayName("ContactUs Us")]
    public class ContactUs
    {
        [DisplayName("ContactUs Id")]
        public int ID { get; set; }

        [DisplayName("Title")]
        [StringLength(160)]
        public string ContactHeader { get; set; }

        [DisplayName("Description")]
        [StringLength(160)]
        public string Content { get; set; }

        [DisplayName("Is Responded")]
        [ScaffoldColumn(false)]
        public Boolean Responded { get; set; }

		[Display(Name = "User Name")]
        [StringLength(15)]
        public string ContactName { get; set; }
       
        [Phone]
		[Display(Name = "Phone")]
        [StringLength(15)]
        public string Phone { get; set; }

		[EmailAddress]
		[Display(Name = "Email")]
        [StringLength(20)]
        public string Email { get; set; }

        [DisplayName("Contact Date")]
        public DateTime ContactDate { get; set; }

    }
}
