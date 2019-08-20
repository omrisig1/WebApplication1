using System;
using System.Collections.Generic;
using System.Linq;

namespace OtoSpaMVC.Models.OtherHelperModels
{
    public class hAprioriFunctionality
    {
        public static hAprioriData[] wrapProductsItems(PurchaseItem[] vector)
        {
            hAprioriData[] wrapped =
                vector.Select(v => new hAprioriData(v)).ToArray();
            return wrapped;
        }

        public static hAprioriData[][] wrapProductsItems(PurchaseItem[][] vectors)
        {
            hAprioriData[][] wrapped =
                vectors.Select(delegate (ICollection<PurchaseItem> vector)
                {
                    return vector.Select(v => new hAprioriData(v)).ToArray();
                }).ToArray();

            return wrapped;
        }

        public static Product[][] extractProducts(PurchaseItem[][] vectors)
        {
            Product[][] extracted =
                vectors.Select(delegate (ICollection<PurchaseItem> vector)
                {
                    return vector.Select(v => v.Product).ToArray();
                }).ToArray();

            return extracted;
        }
    }
}
