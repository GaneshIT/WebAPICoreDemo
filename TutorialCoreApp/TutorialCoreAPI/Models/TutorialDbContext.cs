using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
//dotnet add package Swashbuckle.AspNetCore.SwaggerGen --version 6.2.3
//dotnet add package Swashbuckle.AspNetCore.SwaggerUI --version 6.2.3
namespace TutorialCoreAPI.Models
{
    public class TutorialDbContext:DbContext
    {
        public TutorialDbContext()
        {

        }
        public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options)
        {

        }
        public DbSet<UserInfo> userinfo { get; set; }
        public DbSet<Tutorial> tutorial { get; set; }

    }
}
