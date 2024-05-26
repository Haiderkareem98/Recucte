using AutoMapper;
using Recruit_Form.Data;
using System;

namespace Recruit.Repository
{
    public class BaseService(IServiceProvider serviceProvider)
    {
      
            protected readonly IConfiguration Configuration =
                serviceProvider.GetService(typeof(IConfiguration)) as IConfiguration ??
                throw new NullReferenceException("IConfiguration is null");

            //protected IMediaFileService UploadService =>
            //    serviceProvider.GetService(typeof(IMediaFileService)) as IMediaFileService ??
            //    throw new NullReferenceException("IMediaFileService is null");
            protected DbContextApp1 DbContext => serviceProvider.GetService(typeof(DbContextApp1)) as DbContextApp1 ??
            throw new NullReferenceException("AppDbContext is null");
            protected IMapper Mapper => serviceProvider.GetService(typeof(IMapper)) as IMapper ??
                                        throw new NullReferenceException("IMapper is null");

            //protected IJwtAuthenticationManager JwtManager =>
            //    serviceProvider.GetService(typeof(IJwtAuthenticationManager)) as IJwtAuthenticationManager ??
            //    throw new NullReferenceException("IJwtAuthenticationManager is null");
        
    }
}
