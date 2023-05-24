using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Exceptions
{
    public class UserPricingPlanNotFoundException: NotFoundException
    {
        public UserPricingPlanNotFoundException(Guid entityId)
           : base($"The Pricing Plan with userId of : {entityId}  doesn't exist in the database.")
        {

        }
    }
}
