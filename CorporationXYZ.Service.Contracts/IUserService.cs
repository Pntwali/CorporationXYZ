using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Service.Contracts
{
    public interface IUserService
    {
        Task SetUSerPlan(Guid userId, Guid planId);
    }
}
