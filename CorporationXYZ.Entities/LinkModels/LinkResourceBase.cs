using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporationXYZ.Entities.LinkModels
{
    public class LinkResourceBase
    {
        public LinkResourceBase()
        { }
        public List<Link> Links { get; set; } = new List<Link>();
    }
}
