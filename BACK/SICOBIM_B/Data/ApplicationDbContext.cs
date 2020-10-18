
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



        public virtual DbSet<User> users { set; get; }
        public virtual DbSet<CatArea> catArea { set; get; }
        public virtual DbSet<CatEstadoDelBien> catEstadoDelBien { set; get; }
        public virtual DbSet<CatEstatus> catEstatus { set; get; }
        public virtual DbSet<CatGarantia> catGarantia { set; get; }
        public virtual DbSet<CatPermiso> catPermiso { set; get; }
        public virtual DbSet<CatPisos> catPisos { set; get; }
        public virtual DbSet<CatRol> catRol { set; get; }
        public virtual DbSet<CatServicio> catServicio { set; get; }
        public virtual DbSet<CatSexo> catSexo { set; get; }
        public virtual DbSet<CatTipoContrato> catTipoContrato { set; get; }
        public virtual DbSet<CatTipoDeBien> catTipoDeBien { set; get; }
        public virtual DbSet<CatTipoEntrada> catTipoEntrada { set; get; }
        public virtual DbSet<CatTipoPartida> catTipoPartida { set; get; }
        public virtual DbSet<CatTipoSalida> catTipoSalida { set; get; }
        public virtual DbSet<CatTurno> catTurno { set; get; }
        public virtual DbSet<CatUnidadDestino> catUnidadDestino { set; get; }
        public virtual DbSet<TblAreaServicio> tblAreaServicio { set; get; }
        public virtual DbSet<TblBienes> tblBienes { set; get; }
        public virtual DbSet<TblConfPerfil> tblConfPerfil { set; get; }
        public virtual DbSet<TblFacturas> tblFacturas { set; get; }
        public virtual DbSet<TblInventarios> tblInventarios { set; get; }
        public virtual DbSet<TblResguardatarios> tblResguardatarios { set; get; }
        public virtual DbSet<TblSalidaBien> tblSalidaBien { set; get; }
       
        
       
        // se agregaron  nuevas tablas 
     

        public virtual DbSet<TblFederalizacion> tblFederalizacion { set; get; }
        public virtual DbSet<TblContratoBien> tblContratoBien { set; get; }
        public virtual DbSet<TblProveedor> tblProveedor { set; get; }
        public virtual DbSet<TblClaveCambs> tblClaveCambs { set; get; }
        public virtual DbSet<TblClaveSaica> tblClaveSaica { set; get; }
        public virtual DbSet<TblBienesEquMedico> tblBienesEquMedicos { set; get; }
        public virtual DbSet<TblBienesSistemas> tblBienesSistemas { set; get; }
        public virtual DbSet<TblInstrumentalMedico> tblInstrumentalMedico { set; get; }







    }
}
