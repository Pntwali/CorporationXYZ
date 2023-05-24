using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Exceptions
{
    public class EntityNotFoundException<TEntity> : NotFoundException
    {
        public EntityNotFoundException(Guid entityId)
            : base($"The entity of type '{typeof(TEntity).Name}' with : {entityId}  doesn't exist in the database.")
        {

        }

        
    }

   

}
