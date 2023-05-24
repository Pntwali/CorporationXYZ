using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class Notification
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Recipient is required.")]
        public string Recipient { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }

        [Required(ErrorMessage = "NotificationType is required.")]
        public string NotificationType { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }

        // Relationships
        public User User { get; set; }

    }
}
