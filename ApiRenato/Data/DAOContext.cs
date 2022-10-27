using ApiRenato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApiRenato.Data
{
    public class DAOContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DAOContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Pessoa> Pessoas { get; set; }



    }
}
