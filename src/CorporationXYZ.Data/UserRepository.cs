using CorporationXYZ.Contracts;
using CorporationXYZ.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public PricingPlan GetUserPlan(Guid userId)
        {
            var UserPlan = RepositoryContext.Users.Include(c => c.PricingPlanId).FirstOrDefault(c => c.Id == userId)?.PricingPlan;
            return UserPlan;
        }

       
    }
}
