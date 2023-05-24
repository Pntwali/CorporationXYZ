using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class Quota
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "UserId is required.")]
        public Guid UserId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "MaxRequestsPerMonth must be a positive number.")]
        public int MaxRequestsPerMonth { get; set; }

        // Relationships
        public User User { get; set; }
    }
}
