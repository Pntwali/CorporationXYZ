using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Models
{
    public class User : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        public Guid? PricingPlanId { get; set; }

        // Relationships
        public PricingPlan? PricingPlan { get; set; }
        public ICollection<ClientRateLimitPolicy>? RateLimitPolicies { get; set; }
        public UsageStatistics? UsageStatistics { get; set; }
        public BillingInformation? BillingInformation { get; set; }
        public ICollection<Notification>? Notifications { get; set; }
        public ICollection<AuditTrail>? AuditTrails { get; set; }
        // Use IdentityUserRole<Guid> instead of IdentityUserRole<string> for the roles relationship

    }
}
