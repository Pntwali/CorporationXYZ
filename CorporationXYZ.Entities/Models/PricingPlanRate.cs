using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class PricingPlanRate
    {
        public Guid Id { get; set; }
        public Guid PricingPlanId { get; set; }

        [Required(ErrorMessage = "NotificationType is required.")]
        public int NotificationType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Rate must be a positive number.")]
        public decimal Rate { get; set; }

        // Relationships
        public PricingPlan PricingPlan { get; set; }
    }
}
