using CorporationXYZ.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CorporationXYZ.Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
             new ApplicationRole
             {
                 Id = new Guid("FE617476-D8EE-4C41-B1C2-08DAD1F7E9A4"),
                 Name = "Manager",
                 NormalizedName = "MANAGER"
             },
             new ApplicationRole
             {
                 Id = new Guid("668814E8-1EED-40AE-052B-08DAD1FC717A"),
                 Name = "Administrator",
                 NormalizedName = "ADMINISTRATOR"
             },
             new ApplicationRole
             {
                 Id = new Guid("BA2CD64A-E1C6-4238-052C-08DAD1FC717A"),
                 Name = "Consumer",
                 NormalizedName = "CONSUMER"
             }
             );
        }
    }
  }
