using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public class GroupManager : IGroupService
    {


        GroupRepository groupRepository = new GroupRepository(); 

            
        public Group AddT(Group t)
        {
            return groupRepository.TAdd(t);
        }

        public void DeleteT(int id)
        {
            groupRepository.TDelete(id);
        }

        public List<Group> GetAll()
        {
           return  groupRepository.GetAll();
        }

        public void UpdateT(int id, Group t)
        {
            groupRepository.TUpdate(id, t); 
        }
    }
}
