using Accord.MachineLearning.Rules;
using Microsoft.EntityFrameworkCore;
using OtoSpaMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models.OtherHelperModels
{
    // Updateable-Lazy-Singelton(ish) Helper Class
    public class hAprioriClassifier
    {
        private ApplicationDbContext _context;
        public hAprioriClassifier(ApplicationDbContext context)
            => this._context = context;

        public int ID { get; set; }
        private AssociationRuleMatcher<hAprioriData> classifier { get; set; }

        // This method should be timed with a tool, and not called over and over.
        public void initClassifier()
        {
            hAprioriClassifier existing = _context.AprioriClassifier.SingleOrDefault();
            if (existing != null && existing.classifier != null)
                this.classifier = existing.classifier;
            else
                this.classifier = LearnPurchases();
        }

        /** TIMED FUNCTION **/
        private AssociationRuleMatcher<hAprioriData> LearnPurchases()
        {
            PurchaseItem[][] purchaseVectors =
                _context.Purchase.Include(p => p.Items).Select(p => p.Items.ToArray()).ToArray();

            //var map = purchaseVectors.Select(delegate (ICollection<PurchaseItem> vector) {
            //    return vector.AsQueryable().Select(v => v.ProductID).ToArray();
            //}).ToArray();
            hAprioriData[][] map = hAprioriFunctionality.wrapProductsItems(purchaseVectors);

            // Create a new a-priori learning algorithm with support 1
            Apriori<hAprioriData> apriori =
                new Apriori<hAprioriData>(
                    threshold: 1, confidence: 0);

            // Use the algorithm to learn a set matcher
            AssociationRuleMatcher<hAprioriData> classifier = apriori.Learn(map);
            return classifier;
        }

        public void update(AssociationRuleMatcher<hAprioriData> classifier)
        {
            if (classifier != null && !this.classifier.Equals(classifier))
                this.classifier = classifier;
        }

        public AssociationRuleMatcher<hAprioriData> getClassifier()
        {
            if (this.classifier == null)
                initClassifier();
            return this.classifier;
        }

    }
}
