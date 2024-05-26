using AutoMapper;
using Recruit.Form;
using Recruit.Model;
using Recruit.Model.Response;
using Recruit_Form.Data;

namespace Recruit.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContextApp1 _contextApp1;
        private readonly IMapper mapper1;
        public UserRepository(DbContextApp1 contextApp1, IMapper mapper)
        {
            _contextApp1 = contextApp1;
            mapper1 = mapper;
        }
        public async Task<AuthResult> Registration(RegisterDto user)
        {
            /*
             * اذا اي كولوم في هذه الجدول يساوي اليوزر الجاليك من الي تي او فسويلي هيج
             */
            if (_contextApp1.Users.Any(x => x.UserName.Equals(user.Username)))
            {
                return new AuthResult { IsSuccess = false,UserName=user.Username ,Message = "اليوزر موجود مسبقا" };
            }
            if (_contextApp1.Users.Any(x => x.Email.Equals(user.Email)))
            {
                return new AuthResult { IsSuccess = false, Message = "الايميل موجود مسبقا" };
            }
            var Reg = mapper1.Map<UserA>(user);
            await _contextApp1.AddAsync(Reg);
            _contextApp1.SaveChanges();
            return new AuthResult { IsSuccess = true, UserName = Reg.UserName, Message="تم الاضافه ينجاح" };
        }

    }


}
