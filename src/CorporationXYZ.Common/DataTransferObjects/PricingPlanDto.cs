using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Shared.DataTransferObjects
{
    public record PricingPlanDto
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; init; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; init; }
        [Required]
        public int MaxRequestsPerMinute { get; init; }
        [Required]
        public int MaxRequestsPerMonth { get; init; }
    }
}
