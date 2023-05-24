using CorporationXYZ.Entities.Models;
using CorporationXYZ.Repository.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CorporationXYZ.Repository;
public class RepositoryContext :  IdentityDbContext<User, ApplicationRole, Guid>
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
    : base(options)
    {

    }

    public DbSet<AuditTrail>? AuditTrails { get; set; }
    public DbSet<BillingInformation>? BillingInformation { get; set; }
    public DbSet<ClientRateLimit>? ClientRateLimit { get; set; }
    public DbSet<ClientRateLimitPolicy>? ClientRateLimitPolicies { get; set; }
    public DbSet<Notification>? Notifications { get; set; }
    public DbSet<PricingPlan>? PricingPlans { get; set; }
    public DbSet<PricingPlanRate>? PricingPlanRates { get; set; }
    public DbSet<Quota>? Quota { get; set; }
    //public DbSet<RateLimitCounter>? RateLimitCounters { get; set; }
    public DbSet<UsageStatistics>? UsageStatistics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new PricingPlanConfiguration());
        modelBuilder.ApplyConfiguration(new PricingPlanRateConfiguration());
    }

}
