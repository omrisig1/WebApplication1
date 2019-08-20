using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accord.MachineLearning.Rules;
using FluentScheduler;
using OtoSpaMVC.Data;

namespace OtoSpaMVC.Models.OtherHelperModels
{
    public class tLearningJob : IJob
    {
        private readonly ApplicationDbContext _context;

        public tLearningJob(ApplicationDbContext context)
            => _context = context;

        public void Execute()
        {
            hAprioriClassifier classifier = _context.AprioriClassifier.SingleOrDefault();
            if (classifier == null) {
                classifier = new hAprioriClassifier(_context);
                classifier.initClassifier();
                _context.AprioriClassifier.Add(classifier);
            }
            else {
                classifier.initClassifier();
                _context.AprioriClassifier.Update(classifier);
            }
            _context.SaveChanges();
        }
    }
}
