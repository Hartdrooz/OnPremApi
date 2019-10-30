using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid.Prem.Client.Model
{
    public class Insurance
    {        
        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public IList<Claim> Claims { get; set; }
    }

    public class Claim 
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public int InsuranceId { get; set; }

        public Insurance Insurance { get; set; }
    }
}
