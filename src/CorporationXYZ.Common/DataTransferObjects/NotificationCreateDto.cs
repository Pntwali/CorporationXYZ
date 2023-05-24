using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Shared.DataTransferObjects
{
    public record NotificationCreateDto
    {
        public Guid UserId { get; init; }

        public string? Recipient { get; init; }

        public string? Message { get; init; }

        public string? NotificationType { get; init; }
    }
}
