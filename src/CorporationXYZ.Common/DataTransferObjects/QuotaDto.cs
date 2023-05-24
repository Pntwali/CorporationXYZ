using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Shared.DataTransferObjects
{
    public record QuotaDto
    {
        [Required(ErrorMessage = "UserId is required.")]
        public Guid UserId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "MaxRequestsPerMonth must be a positive number.")]
        public int MaxRequestsPerMonth { get; set; }
    }
}
