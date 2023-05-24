using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class UsageStatistics
    {
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "UserId is required.")]
        public Guid UserId { get; set; }

        [Range(1, 12, ErrorMessage = "Month must be between 1 and 12.")]
        public int Month { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "RequestCount must be a positive number.")]
        public int RequestCount { get; set; }

        // Relationships
        public User User { get; set; }
    }
}
