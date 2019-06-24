using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingProject.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //naqi
            optionsBuilder.UseSqlServer(@"Server=.;Database=TestingProject;Trusted_Connection=True;ConnectRetryCount=0");
            //optionsBuilder.UseSqlServer(@"Server=.;Database=UNEEKDB;Trusted_Connection=True;");
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public Context()
        {
            Database.SetCommandTimeout(150000);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
