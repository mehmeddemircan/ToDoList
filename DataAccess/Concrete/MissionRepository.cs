using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class MissionRepository : EfEntityRepositoryBase<Mission, ApplicationDbContext>, IMissionRepository
    {
    }
}
