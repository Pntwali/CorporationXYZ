using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Shared.DataTransferObjects
{
    public record PricingPlanRateDto
    {
        public Guid PricingPlanId { get; init; }

        [Required(ErrorMessage = "NotificationType is required.")]
        public int NotificationType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Rate must be a positive number.")]
        public decimal Rate { get; init; }
    }
}
