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
    public class PricingPlanRateConfiguration : IEntityTypeConfiguration<PricingPlanRate>
    {
        public void Configure(EntityTypeBuilder<PricingPlanRate> builder)
        {
            builder.HasData(

                    new PricingPlanRate
                    {
                        //1
                        PricingPlanId = new Guid("1431845e-b779-4310-8293-284b0727db41"),
                        Id = Guid.NewGuid(),
                        NotificationType = 1, // SMS
                        Rate = 0.05m
                    },
                    new PricingPlanRate
                    {
                        //1
                        Id = Guid.NewGuid(),
                        PricingPlanId = new Guid("1431845e-b779-4310-8293-284b0727db41"),
                        NotificationType = 2, // Email
                        Rate = 0.01m
                    }
                   ,

                    new PricingPlanRate
                    {
                        //2
                        Id = Guid.NewGuid(),
                        PricingPlanId = new Guid("33269f38-6656-49f5-8c5e-e4efe71d8782"),
                        NotificationType = 1, // SMS
                        Rate = 0.03m
                    },
                    new PricingPlanRate
                    {
                        //2
                        Id = Guid.NewGuid(),
                        PricingPlanId = new Guid("33269f38-6656-49f5-8c5e-e4efe71d8782"),
                        NotificationType = 2, // Email
                        Rate = 0.005m
                    }
                  ,

                     new PricingPlanRate
                     {
                         //3
                         Id = Guid.NewGuid(),
                         PricingPlanId = new Guid("23a92d2b-76dd-4bdd-80bb-02fb83cc1348"),
                         NotificationType = 1, // SMS
                         Rate = 0.02m
                     },
                     new PricingPlanRate
                     {
                         //3
                         Id = Guid.NewGuid(),
                         PricingPlanId = new Guid("23a92d2b-76dd-4bdd-80bb-02fb83cc1348"),
                         NotificationType = 2, // Email
                         Rate = 0.001m
                     }

             );
        }
    }
}
