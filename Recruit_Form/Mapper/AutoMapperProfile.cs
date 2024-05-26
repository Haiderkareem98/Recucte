using AutoMapper;
using Recruit.Form;
using Recruit.Model;
using Recruit_Form.Form;
using Recruit_Form.Model;

namespace Recruit_Form.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<RequsteInformation, PersonalInformation>();
            CreateMap<PersonalInformation,RequsteInformation>();
            CreateMap<RegisterDto, UserA>();
        }
    }
}
