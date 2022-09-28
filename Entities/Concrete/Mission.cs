using Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Mission : BaseEntity
    {
        public string Name { get; set; }

        public bool IsCompleted { get; set; } = false;

        public bool IsStarred { get; set; } = false;

        public string? MissionNote { get; set; }

        public DateTime? EndDate { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

    }
}
