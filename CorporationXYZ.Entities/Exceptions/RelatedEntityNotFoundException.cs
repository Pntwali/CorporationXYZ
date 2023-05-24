using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.Exceptions
{
    public class RelatedEntityNotFoundException<TEntity, TEntityPropertyValue> : NotFoundException
    {
        public RelatedEntityNotFoundException(string RelationShipColumn, TEntityPropertyValue entityPropertyValue)
            : base($"The entity of type '{typeof(TEntity).Name}' with {RelationShipColumn} value of  {entityPropertyValue} doesn't exist in the database.")
        {

        }


    }
}
