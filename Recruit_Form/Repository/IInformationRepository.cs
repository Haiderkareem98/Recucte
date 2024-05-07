using Microsoft.VisualBasic;
using Recruit_Form.Form;
using Recruit_Form.Model;
using Recruit_Form.Model.Response;

namespace Recruit_Form.Repository
{
    public interface IInformationRepository 
    {
        Task<GlobalResponse> GetAll(PagingForm paging);
        PersonalInformation Get(int id);
        Task<GlobalResponse> AddPer(RequsteInformation requste);
       // void Update(int id, PersonalInformation information);
        void Delete(int id);
      
    }

}
