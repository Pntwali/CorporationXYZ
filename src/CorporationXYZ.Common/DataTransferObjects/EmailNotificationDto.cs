using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Shared.DataTransferObjects
{
    public record EmailNotificationDto
    {
        [Required]
        public Guid UserId { get; init; }
        [Required]
        public string Recipient { get; init; }
        [Required]
        public string Subject { get; init; }
        [Required]
        public string Body { get; init; }
    }
}
