using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public class MissionManager : IMissionService
    {


        MissionRepository missionRepository = new MissionRepository();

        public Mission AddT(Mission t)
        {
                return missionRepository.TAdd(t);
        }

        public void DeleteT(int id)
        {
                missionRepository.TDelete(id);
        }

        public List<Mission> GetAll()
        {
            return missionRepository.GetAll();
        }

        public void UpdateT(int id, Mission t)
        {
            missionRepository.TUpdate(id, t);   
        }
    }
}