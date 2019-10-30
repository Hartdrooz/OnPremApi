using Hybrid.Prem.Client.Model;
using NLipsum.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid.Prem.Client.Factory
{
    public class InsuranceFactory : IInsuranceFactory
    {
        public Insurance CreateClaims()
        {
            var insurance = new Insurance
            {
                CreatedOn = DateTime.Now
            };

            insurance.Claims = new List<Claim>();

            var lipsum = new LipsumGenerator();

            var rand = new Random();
            int seq = rand.Next(1, 20);
            for (int i = 0; i < seq; i++)
            {
                insurance.Claims.Add(new Claim
                {
                    Type = lipsum.GenerateSentences(1).First(),
                    Description = lipsum.GenerateParagraphs(1).First(),
                    Amount = 1.1756 * rand.Next(1, 10000)
                }); ;
            }

            return insurance;
        }
    }
}
