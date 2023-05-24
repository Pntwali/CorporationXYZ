using CorporationXYZ.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Contracts
{
    public interface IUserRepository
    {
        public PricingPlan GetUserPlan(Guid userId);
        
    }
}
