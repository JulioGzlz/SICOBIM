
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SICOBIM_B.Entities;
using SICOBIM_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SICOBIM_B.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
       public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            //options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblConfPerfil>().HasNoKey();

            //modelBuilder.Entity<TblConfPerfil>()
            //        .HasKey(m => new
            //        {

            //            m.CatPermiso
            //        });


        }



        public DbSet<User> users { set; get; }
        public DbSet<TblConfPerfil> tblConfPerfil { set; get; }



    }
}
