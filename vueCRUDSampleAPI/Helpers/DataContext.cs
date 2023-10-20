using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using vueCRUDSampleAPI.Entities;

namespace vueCRUDSampleAPI.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("ApiDatabase"));
        }

        public DbSet<vueUser> vueUsers { get; set; }
    }
}
