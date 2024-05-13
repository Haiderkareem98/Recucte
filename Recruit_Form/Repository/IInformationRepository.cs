using Microsoft.VisualBasic;
using Recruit_Form.Form;
using Recruit_Form.Helper;
using Recruit_Form.Model;
using Recruit_Form.Model.Response;

namespace Recruit_Form.Repository
{
    public interface IInformationRepository 
    {
        Task<GlobalResponse<PersonalInformation>> GetAll(PagingForm paging,string? FlterValue);
       //   PersonalInformation Get(int id);
       Task<PagedResponse<PersonalInformation>>AddPer(RequsteInformation requste);
       // void Update(int id, PersonalInformation information);
      //  void Delete(int id);
      
    }

}
