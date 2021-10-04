using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Model;

namespace WebApplication
{
    public class PhoneContext : DbContext
    {
        public PhoneContext()
        {
        }

        public PhoneContext(DbContextOptions<PhoneContext> context) : base(context)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Integrated Security=true;");

        public DbSet<PhoneEntry> PhoneEntries { get; set; }
    }
}