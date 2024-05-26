using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Recruit_Form.Migrations;
using System.Data;
using System.Security.Claims;
using System;
using Recruit_Form.Data;

namespace Recruit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController(IServiceProvider serviceProvider) : ControllerBase
    {
        private IConfiguration _configuration = serviceProvider.GetService(typeof(IConfiguration)) as IConfiguration ??
                                           throw new NullReferenceException("IConfiguration is null");

        protected Guid? UserId => new(GetClaim(ClaimTypes.NameIdentifier) ?? Guid.Empty.ToString());
        protected User? UserInfo => UserId != Guid.Empty ? DbContext.Users.Find(UserId) : null;
       // protected Roles Role => Enum.TryParse<Roles>(GetClaim(ClaimTypes.Role), out var role) ? role : Roles.NotAuthorized;


       // protected IMediaFileService UploadService =>
       // serviceProvider.GetService(typeof(IMediaFileService)) as IMediaFileService ??
       // throw new NullReferenceException("IMediaFileService is null");
        protected DbContextApp1 DbContext => serviceProvider.GetService(typeof(DbContextApp1)) as DbContextApp1 ??
        throw new NullReferenceException("AppDbContext is null");
        protected IMapper Mapper => serviceProvider.GetService(typeof(IMapper)) as IMapper ??
        throw new NullReferenceException("IMapper is null");

        //protected IJwtAuthenticationManager JwtManager =>
        //    serviceProvider.GetService(typeof(IJwtAuthenticationManager)) as IJwtAuthenticationManager ??
        //    throw new NullReferenceException("IJwtAuthenticationManager is null");

        private string? GetClaim(string type)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var claim = claimsIdentity?.FindFirst(type);
            return claim?.Value;
        }
    }
}
