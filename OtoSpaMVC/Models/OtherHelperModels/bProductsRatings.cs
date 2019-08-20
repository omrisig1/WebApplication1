using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    public class bProductsRatings
    {
        public Product product { get; set; }
        public IEnumerable<Rating> ratings { get; set; }
        public int[] stars { get; set; }
        public void countStars()
        {
            if (ratings.Count() > 0)
            {
                stars = new int[5];
                for (int i = 0; i < 5; i++)
                    stars[i] =
                        ratings.Where(
                            s => s.ProductRating == (1 + i)
                        ).Count();
            }
        }
    }
}
