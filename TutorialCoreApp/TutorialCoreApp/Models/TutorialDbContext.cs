using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialCoreApp.Models
{
    public class TutorialDbContext:DbContext
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext> options):base(options)
        {

        }
        public DbSet<Tutorial> tutorial { get; set; }
        public DbSet<UserInfo> userinfo { get; set; }
    }
}

//MVC Filters

//UI layer->business layer->Data Layer
//UI layer->Service layer>Data layer
