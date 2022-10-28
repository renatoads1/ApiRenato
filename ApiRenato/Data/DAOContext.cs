using ApiRenato.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

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

        protected override void OnModelCreating (ModelBuilder builder) {
            builder.Entity<Pessoa>().HasData(
                new List<Pessoa>()
                    {
                        new Pessoa(){
                        Id = 1,
                        Nome = "Renato",
                        Sobrenome = "Azevedo",
                        Usuario = "renatoads1",
                        Senha = "r3n4t0321"
                        },
                        new Pessoa(){
                        Id = 2,
                        Nome = "Isabela",
                        Sobrenome = "Lacerda",
                        Usuario = "isabela321",
                        Senha = "r3n4t0321"
                        },
                        new Pessoa(){
                        Id = 3,
                        Nome = "Julia",
                        Sobrenome = "Lacerda",
                        Usuario = "julia321",
                        Senha = "r3n4t0321"
                        }
                    }
                );
            
        }


    }
}
