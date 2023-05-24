using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class PricingPlan
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        [Required]
        public int MaxRequestsPerMinute { get; set; }
        [Required]
        public int MaxRequestsPerMonth { get; set; }

        // Relationships
        public ICollection<User> Users { get; set; }
        public ICollection<PricingPlanRate> PricingPlanRates { get; set; }
    
    }
}
