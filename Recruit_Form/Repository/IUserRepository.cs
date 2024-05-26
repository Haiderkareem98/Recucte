using Recruit.Form;
using Recruit.Model.Response;

namespace Recruit.Repository
{
    public interface IUserRepository
    {
        Task<AuthResult> Registration(RegisterDto user);
    }
}