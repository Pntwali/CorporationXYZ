using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Repository.Configuration
{
    public class PricingPlanConfiguration : IEntityTypeConfiguration<PricingPlan>
    {
        public void Configure(EntityTypeBuilder<PricingPlan> builder)
        {
            builder.HasData(
                new PricingPlan
                {
                    Id = new Guid("1431845e-b779-4310-8293-284b0727db41"),
                    Name = "Basic",
                    Description = "Basic plan with limited usage",
                    MaxRequestsPerMinute = 2,
                    MaxRequestsPerMonth = 10,
                    
                },
                new PricingPlan
                {
                    Id = new Guid("33269f38-6656-49f5-8c5e-e4efe71d8782"),
                    Name = "Standard",
                    Description = "Standard plan for medium usage",
                    MaxRequestsPerMinute = 5,
                    MaxRequestsPerMonth = 50,
                    
                },
                new PricingPlan
                {
                    Id = new Guid("23a92d2b-76dd-4bdd-80bb-02fb83cc1348"),
                    Name = "Premium",
                    Description = "Premium plan for high usage",
                    MaxRequestsPerMinute = 10,
                    MaxRequestsPerMonth = 100,
                    
                }
            );

        }
    }


}
