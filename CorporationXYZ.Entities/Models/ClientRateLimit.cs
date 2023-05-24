using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class ClientRateLimit
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "UserId is required.")]
        public Guid UserId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "MaxRequestsPerSecond must be greater than 0.")]
        public int MaxRequestsPerSecond { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "MaxRequestsPerMinute must be greater than 0.")]
        public int MaxRequestsPerMinute { get; set; }

        // Relationships
        public User User { get; set; }
    }
}
