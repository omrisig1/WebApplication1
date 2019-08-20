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
    [DisplayName("Supplier Of Product")]
    public class ProductSupplier
    {
        [DisplayName("Product-Supplier Id")]
        public int ID { get; set; }

        [DisplayName("Supplier Id")]
        public int SupplierID { get; set; }

        [DisplayName("Supplier")]
		[ForeignKey(nameof(SupplierID))]
        public virtual Supplier Supplier { get; set; }

        [DisplayName("Product Id")]
        public int ProductID { get; set; }

        [DisplayName("Product")]
		[ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
    }
}
