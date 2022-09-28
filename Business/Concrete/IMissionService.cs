using Entities.Concrete;

namespace Business.Concrete
{
    public interface IMissionService
    {

        public List<Mission> GetAll();

        public Mission AddMission(Mission mission);
        
        public void UpdateMission(int id, Mission mission); 

        public void DeleteMission(int id);  
    }
}