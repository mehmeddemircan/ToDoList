using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionsController : ControllerBase
    {



        MissionManager missionManager = new MissionManager();
         
        [HttpGet("get-all")]

        public List<Mission> GetAll()
        {
            return missionManager.GetAll();
        }

        // adding new mission 
        [HttpPost("add-mission")]

        public Mission AddMission(Mission mission)
        {
            return missionManager.AddT(mission); 
        }


        [HttpPut("update-mission")]
        
        
        public void  UpdateMission (int id , Mission mission)
        {
            mission.Id = id; 
            missionManager.UpdateT(id, mission); 
        }


        [HttpDelete("delete-mission")]

        public void DeleteMission(int id)
        {
            missionManager.DeleteT(id);
        }





    }
}
