using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public class MissionManager : IMissionService
    {


        MissionRepository missionRepository = new MissionRepository();

        public Mission AddMission(Mission mission)
        {
            return missionRepository.TAdd(mission);
        }

        public void DeleteMission(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mission> GetAll()
        {
            return missionRepository.GetAll();
        }

        public void  UpdateMission(int id, Mission mission)
        {
              missionRepository.TUpdate(id, mission);
        }
    }
}