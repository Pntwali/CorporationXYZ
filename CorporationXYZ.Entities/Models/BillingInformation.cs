using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class BillingInformation
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "TotalPrice must be a positive number.")]
        public decimal TotalPrice { get; set; }

        // Relationships
        public User User { get; set; }
    }
}
