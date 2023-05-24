using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class ClientRateLimitPolicy
    {
        [Required(ErrorMessage = "ClientId is required.")]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Period must be greater than 0.")]
        public int Period { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Limit must be greater than 0.")]
        public int Limit { get; set; }

        public User User { get; set; }
    }
}
