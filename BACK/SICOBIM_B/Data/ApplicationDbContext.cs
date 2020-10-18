
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
        public DbSet<CatArea> catArea { set; get; }
        public DbSet<CatEstadoDelBien> catEstadoDelBien { set; get; }
        public DbSet<CatEstatus> catEstatus { set; get; }
        public DbSet<CatGarantia> catGarantia { set; get; }
        public DbSet<CatPermiso> catPermiso { set; get; }
        public DbSet<CatPisos> catPisos { set; get; }
        public DbSet<CatRol> catRol { set; get; }
        public DbSet<CatServicio> catServicio { set; get; }
        public DbSet<CatSexo> catSexo { set; get; }
        public DbSet<CatTipoContrato> catTipoContrato { set; get; }
        public DbSet<CatTipoDeBien> catTipoDeBien { set; get; }
        public DbSet<CatTipoEntrada> catTipoEntrada { set; get; }
        public DbSet<CatTipoPartida> catTipoPartida { set; get; }
        public DbSet<CatTipoSalida> catTipoSalida { set; get; }
        public DbSet<CatTurno> catTurno { set; get; }
        public DbSet<CatUnidadDestino> catUnidadDestino { set; get; }
        public DbSet<TblAreaServicio> tblAreaServicio { set; get; }
        public DbSet<TblBienes> tblBienes { set; get; }
        public DbSet<TblConfPerfil> tblConfPerfil { set; get; }
        public DbSet<TblFacturas> tblFacturas { set; get; }
        public DbSet<TblInventarios> tblInventarios { set; get; }
        public DbSet<TblResguardatarios> tblResguardatarios { set; get; }
        public DbSet<TblSalidaBien> tblSalidaBien { set; get; }
       
        
       
        // se agregaron  nuevas tablas 
     

        public DbSet<TblFederalizacion> tblFederalizacion { set; get; }
        public DbSet<TblContratoBien> tblContratoBien { set; get; }
        public DbSet<TblProveedor> tblProveedor { set; get; }
        public DbSet<TblClaveCambs> tblClaveCambs { set; get; }
        public DbSet<TblClaveSaica> tblClaveSaica { set; get; }
        public DbSet<TblBienesEquMedico> tblBienesEquMedicos { set; get; }
        public DbSet<TblBienesSistemas> tblBienesSistemas { set; get; }
        public DbSet<TblInstrumentalMedico> tblInstrumentalMedico { set; get; }







    }
}
