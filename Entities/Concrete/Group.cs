using Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Group : BaseEntity 
    {
        public string Title { get; set; }

        public List<Mission> Missions { get; set; }
    }
}
