using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {

        GroupManager groupManager = new GroupManager(); 


        [HttpGet("get-all-group")]

        public List<Group> GetAllGroup()
        {
            return groupManager.GetAll(); 
        }


        [HttpPost("add-group")]

        public Group AddGroup (Group group)
        {
            return groupManager.AddT(group); 
        }



        [HttpDelete("delete-group")]

        public void DeleteGroup ( int id)
        {
            
        }

        [HttpPut("update-group")]

        public void UpdateGroup (int id, Group group)
        {
            group.Id = id;
        }


    }
}
