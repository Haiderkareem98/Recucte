using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Recruit_Form.Model;
using System.Data.Common;

namespace Recruit_Form.Data
{
    public class DbContextApp1 :IdentityDbContext<AppUsers>
    {
        public DbContextApp1(DbContextOptions<DbContextApp1> options) : base(options)
        {
        }

      public DbSet<PersonalInformation>PerInform { get; set; }
      //  DbSet<Users> Users { get; set; }

    }
}
