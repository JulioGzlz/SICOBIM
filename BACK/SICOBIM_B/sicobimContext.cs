using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SICOBIM_B
{
    public partial class sicobimContext : DbContext
    {
        public sicobimContext()
        {
        }

        public sicobimContext(DbContextOptions<sicobimContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatArea> CatArea { get; set; }
        public virtual DbSet<CatEstadoDelBien> CatEstadoDelBien { get; set; }
        public virtual DbSet<CatEstatus> CatEstatus { get; set; }
        public virtual DbSet<CatGarantia> CatGarantia { get; set; }
        public virtual DbSet<CatPermiso> CatPermiso { get; set; }
        public virtual DbSet<CatPiso> CatPiso { get; set; }
        public virtual DbSet<CatRol> CatRol { get; set; }
        public virtual DbSet<CatServicio> CatServicio { get; set; }
        public virtual DbSet<CatSexo> CatSexo { get; set; }
        public virtual DbSet<CatTipoContrato> CatTipoContrato { get; set; }
        public virtual DbSet<CatTipoDeBien> CatTipoDeBien { get; set; }
        public virtual DbSet<CatTipoEntrada> CatTipoEntrada { get; set; }
        public virtual DbSet<CatTipoPartida> CatTipoPartida { get; set; }
        public virtual DbSet<CatTipoSalida> CatTipoSalida { get; set; }
        public virtual DbSet<CatTurno> CatTurno { get; set; }
        public virtual DbSet<CatUnidadDestino> CatUnidadDestino { get; set; }
        public virtual DbSet<CtrlUsuarios> CtrlUsuarios { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<TblAreaServicio> TblAreaServicio { get; set; }
        public virtual DbSet<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual DbSet<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual DbSet<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual DbSet<TblClaveCambs> TblClaveCambs { get; set; }
        public virtual DbSet<TblClaveSaica> TblClaveSaica { get; set; }
        public virtual DbSet<TblConfPerfil> TblConfPerfil { get; set; }
        public virtual DbSet<TblContratoBien> TblContratoBien { get; set; }
        public virtual DbSet<TblFacturas> TblFacturas { get; set; }
        public virtual DbSet<TblFederalizacion> TblFederalizacion { get; set; }
        public virtual DbSet<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
        public virtual DbSet<TblInventarios> TblInventarios { get; set; }
        public virtual DbSet<TblProveedor> TblProveedor { get; set; }
        public virtual DbSet<TblResguardatarios> TblResguardatarios { get; set; }
        public virtual DbSet<TblSalidas> TblSalidas { get; set; }
        //public virtual DbSet<TblSalidaBienEquMedico> TblSalidaBienEquMedicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=sicobim;Username=postgres;Password=lagoz2020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatArea>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdusuarioMod).HasColumnName("idusuarioMod");

                entity.Property(e => e.UsuarioAlta).HasColumnName("usuarioAlta");
            });

            modelBuilder.Entity<CatEstadoDelBien>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatEstatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatGarantia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.AñosGarantia).HasColumnName("añosGarantia");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatPermiso>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Permiso).HasColumnName("permiso");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatPiso>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Piso).HasColumnName("piso");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatRol>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.IdusuarioMod).HasColumnName("idusuarioMod");

                entity.Property(e => e.Rol).HasColumnName("rol");
            });

            modelBuilder.Entity<CatServicio>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdusuarioMod).HasColumnName("idusuarioMod");

                entity.Property(e => e.Servicio).HasColumnName("servicio");

                entity.Property(e => e.UsuarioAlta).HasColumnName("usuarioAlta");
            });

            modelBuilder.Entity<CatSexo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Sexo).HasColumnName("sexo");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatTipoContrato>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Contrato).HasColumnName("contrato");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatTipoDeBien>(entity =>
            {
                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatTipoEntrada>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Tipoentrada).HasColumnName("tipoentrada");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatTipoPartida>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Partidapresupestual).HasColumnName("partidapresupestual");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatTipoSalida>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Tiposalida).HasColumnName("tiposalida");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatTurno>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Turno).HasColumnName("turno");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");
            });

            modelBuilder.Entity<CatUnidadDestino>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.IdusuarioMod).HasColumnName("idusuarioMod");
            });

            modelBuilder.Entity<CtrlUsuarios>(entity =>
            {
                entity.HasIndex(e => e.CatEstatusid);

                entity.HasIndex(e => e.CatRolid);

                entity.HasIndex(e => e.CatSexoid);

                entity.HasIndex(e => e.CatTipoContratoid);

                entity.HasIndex(e => e.CatTurnoid);

                entity.HasIndex(e => e.IdAreaServicioid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Cargo).HasColumnName("cargo");

                entity.Property(e => e.CatEstatusid).HasColumnName("catEstatusid");

                entity.Property(e => e.CatRolid).HasColumnName("catRolid");

                entity.Property(e => e.CatSexoid).HasColumnName("catSexoid");

                entity.Property(e => e.CatTipoContratoid).HasColumnName("catTipoContratoid");

                entity.Property(e => e.CatTurnoid).HasColumnName("catTurnoid");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fechaAlta")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.FechaMod)
                    .HasColumnName("fechaMod")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.IdTok).HasColumnName("idTok");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Numeroempleado).HasColumnName("numeroempleado");

                entity.Property(e => e.Plaza).HasColumnName("plaza");

                entity.Property(e => e.Rfc).HasColumnName("RFC");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatEstatus)
                    .WithMany(p => p.CtrlUsuarios)
                    .HasForeignKey(d => d.CatEstatusid);

                entity.HasOne(d => d.CatRol)
                    .WithMany(p => p.CtrlUsuarios)
                    .HasForeignKey(d => d.CatRolid);

                entity.HasOne(d => d.CatSexo)
                    .WithMany(p => p.CtrlUsuarios)
                    .HasForeignKey(d => d.CatSexoid);

                entity.HasOne(d => d.CatTipoContrato)
                    .WithMany(p => p.CtrlUsuarios)
                    .HasForeignKey(d => d.CatTipoContratoid);

                entity.HasOne(d => d.CatTurno)
                    .WithMany(p => p.CtrlUsuarios)
                    .HasForeignKey(d => d.CatTurnoid);

                entity.HasOne(d => d.IdAreaServicio)
                    .WithMany(p => p.CtrlUsuarios)
                    .HasForeignKey(d => d.IdAreaServicioid);
            });

            
            //modelBuilder.Entity<RefreshToken>(entity =>
            //{
            //    entity.HasIndex(e => e.Userid);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.RefreshToken)
            //        .HasForeignKey(d => d.Userid);
            //});

            modelBuilder.Entity<TblAreaServicio>(entity =>
            {
                entity.HasIndex(e => e.Catareaid);

                entity.HasIndex(e => e.Catservicioid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Catareaid).HasColumnName("catareaid");

                entity.Property(e => e.Catservicioid).HasColumnName("catservicioid");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.Catarea)
                    .WithMany(p => p.TblAreaServicio)
                    .HasForeignKey(d => d.Catareaid);

                entity.HasOne(d => d.Catservicio)
                    .WithMany(p => p.TblAreaServicio)
                    .HasForeignKey(d => d.Catservicioid);
            });

            modelBuilder.Entity<TblBienesEquMedico>(entity =>
            {
                entity.HasIndex(e => e.CatEstadoDelBienid);

                entity.HasIndex(e => e.CatGarantiaid);

                entity.HasIndex(e => e.CatPisosid);

                entity.HasIndex(e => e.CatTipoDeBienesCatTipoDeBienId);

                entity.HasIndex(e => e.CatTipoEntradaid);

                entity.HasIndex(e => e.CatTipoPartidaid);

                entity.HasIndex(e => e.IdAreaServicioid);

                entity.HasIndex(e => e.IdClaveCabmsid);

                entity.HasIndex(e => e.IdClaveSaicaid);

                entity.HasIndex(e => e.IdFacturasIdFactura);

                entity.HasIndex(e => e.IdContratoBienid);

                entity.HasIndex(e => e.IdFederalizacionid);

                entity.HasIndex(e => e.IdInventarioid);

                entity.HasIndex(e => e.IdProveedorid);

                entity.HasIndex(e => e.IdResguardatariosid);

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CatEstadoDelBienid).HasColumnName("catEstadoDelBienid");

                entity.Property(e => e.CatGarantiaid).HasColumnName("catGarantiaid");

                entity.Property(e => e.CatPisosid).HasColumnName("catPisosid");

                entity.Property(e => e.CatTipoDeBienesCatTipoDeBienId).HasColumnName("catTipoDeBienesCatTipoDeBienId");

                entity.Property(e => e.CatTipoEntradaid).HasColumnName("catTipoEntradaid");

                entity.Property(e => e.CatTipoPartidaid).HasColumnName("catTipoPartidaid");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatEstadoDelBien)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.CatEstadoDelBienid);

                entity.HasOne(d => d.CatGarantia)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.CatGarantiaid);

                entity.HasOne(d => d.CatPisos)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.CatPisosid);

                entity.HasOne(d => d.CatTipoDeBienesCatTipoDeBien)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.CatTipoDeBienesCatTipoDeBienId)
                    .HasConstraintName("FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~");

                entity.HasOne(d => d.CatTipoEntrada)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.CatTipoEntradaid);

                entity.HasOne(d => d.CatTipoPartida)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.CatTipoPartidaid);

                entity.HasOne(d => d.IdAreaServicio)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdAreaServicioid);

                entity.HasOne(d => d.IdClaveCabms)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdClaveCabmsid);

                entity.HasOne(d => d.IdClaveSaica)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdClaveSaicaid);

                entity.HasOne(d => d.IdFacturasIdFacturaNavigation)
                .WithMany(p => p.TblBienesEquMedico)
                .HasForeignKey(d => d.IdFacturasIdFactura);

                entity.HasOne(d => d.IdContratoBien)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdContratoBienid);

                entity.HasOne(d => d.IdFederalizacion)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdFederalizacionid);

                entity.HasOne(d => d.IdInventario)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdInventarioid);

                entity.HasOne(d => d.IdProveedor)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdProveedorid);

                entity.HasOne(d => d.IdResguardatarios)
                    .WithMany(p => p.TblBienesEquMedico)
                    .HasForeignKey(d => d.IdResguardatariosid);
            });

            modelBuilder.Entity<TblBienesMuebles>(entity =>
            {
                entity.HasIndex(e => e.CatEstadoDelBienid);

                entity.HasIndex(e => e.CatGarantiaid);

                entity.HasIndex(e => e.CatPisosid);

                entity.HasIndex(e => e.CatTipoDeBienesCatTipoDeBienId);

                entity.HasIndex(e => e.CatTipoEntradaid);

                entity.HasIndex(e => e.CatTipoPartidaid);

                entity.HasIndex(e => e.IdAreaServicioid);

                entity.HasIndex(e => e.IdClaveCabmsid);

                entity.HasIndex(e => e.IdClaveSaicaid);

                entity.HasIndex(e => e.IdContratoBienid);

                entity.HasIndex(e => e.IdFacturasIdFactura);

                entity.HasIndex(e => e.IdFederalizacionid);

                entity.HasIndex(e => e.IdInventariosid);

                entity.HasIndex(e => e.IdResguardatariosid);

                entity.HasIndex(e => e.Iproveedorid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CatEstadoDelBienid).HasColumnName("catEstadoDelBienid");

                entity.Property(e => e.CatGarantiaid).HasColumnName("catGarantiaid");

                entity.Property(e => e.CatPisosid).HasColumnName("catPisosid");

                entity.Property(e => e.CatTipoDeBienesCatTipoDeBienId).HasColumnName("catTipoDeBienesCatTipoDeBienId");

                entity.Property(e => e.CatTipoEntradaid).HasColumnName("catTipoEntradaid");

                entity.Property(e => e.CatTipoPartidaid).HasColumnName("catTipoPartidaid");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Iproveedorid).HasColumnName("IProveedorid");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatEstadoDelBien)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.CatEstadoDelBienid);

                entity.HasOne(d => d.CatGarantia)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.CatGarantiaid);

                entity.HasOne(d => d.CatPisos)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.CatPisosid);

                entity.HasOne(d => d.CatTipoDeBienesCatTipoDeBien)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.CatTipoDeBienesCatTipoDeBienId)
                    .HasConstraintName("FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~");

                entity.HasOne(d => d.CatTipoEntrada)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.CatTipoEntradaid);

                entity.HasOne(d => d.CatTipoPartida)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.CatTipoPartidaid);

                entity.HasOne(d => d.IdAreaServicio)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdAreaServicioid);

                entity.HasOne(d => d.IdClaveCabms)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdClaveCabmsid);

                entity.HasOne(d => d.IdClaveSaica)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdClaveSaicaid);

                entity.HasOne(d => d.IdContratoBien)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdContratoBienid);

                entity.HasOne(d => d.IdFacturasIdFacturaNavigation)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdFacturasIdFactura);

                entity.HasOne(d => d.IdFederalizacion)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdFederalizacionid);

                entity.HasOne(d => d.IdInventarios)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdInventariosid);

                entity.HasOne(d => d.IdResguardatarios)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.IdResguardatariosid);

                entity.HasOne(d => d.Iproveedor)
                    .WithMany(p => p.TblBienesMuebles)
                    .HasForeignKey(d => d.Iproveedorid);
            });

            modelBuilder.Entity<TblBienesSistemas>(entity =>
            {
                entity.HasIndex(e => e.CatEstadoDelBienid);

                entity.HasIndex(e => e.CatGarantiaid);

                entity.HasIndex(e => e.CatPisosid);

                entity.HasIndex(e => e.CatTipoDeBienesCatTipoDeBienId);

                entity.HasIndex(e => e.CatTipoEntradaid);

                entity.HasIndex(e => e.CatTipoPartidaid);

                entity.HasIndex(e => e.IdAreaServicioid);

                entity.HasIndex(e => e.IdClaveCabmsid);

                entity.HasIndex(e => e.IdClaveSaicaid);

                entity.HasIndex(e => e.IdContratoBienid);

                entity.HasIndex(e => e.IdFacturasIdFactura);

                entity.HasIndex(e => e.IdFederalizacionid);

                entity.HasIndex(e => e.IdInventariosid);

                entity.HasIndex(e => e.IdProveedorid);

                entity.HasIndex(e => e.IdResguardatariosid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CatEstadoDelBienid).HasColumnName("catEstadoDelBienid");

                entity.Property(e => e.CatGarantiaid).HasColumnName("catGarantiaid");

                entity.Property(e => e.CatPisosid).HasColumnName("catPisosid");

                entity.Property(e => e.CatTipoDeBienesCatTipoDeBienId).HasColumnName("catTipoDeBienesCatTipoDeBienId");

                entity.Property(e => e.CatTipoEntradaid).HasColumnName("catTipoEntradaid");

                entity.Property(e => e.CatTipoPartidaid).HasColumnName("catTipoPartidaid");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatEstadoDelBien)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.CatEstadoDelBienid);

                entity.HasOne(d => d.CatGarantia)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.CatGarantiaid);

                entity.HasOne(d => d.CatPisos)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.CatPisosid);

                entity.HasOne(d => d.CatTipoDeBienesCatTipoDeBien)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.CatTipoDeBienesCatTipoDeBienId)
                    .HasConstraintName("FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~");

                entity.HasOne(d => d.CatTipoEntrada)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.CatTipoEntradaid);

                entity.HasOne(d => d.CatTipoPartida)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.CatTipoPartidaid);

                entity.HasOne(d => d.IdAreaServicio)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdAreaServicioid);

                entity.HasOne(d => d.IdClaveCabms)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdClaveCabmsid);

                entity.HasOne(d => d.IdClaveSaica)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdClaveSaicaid);

                entity.HasOne(d => d.IdContratoBien)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdContratoBienid);

                entity.HasOne(d => d.IdFacturasIdFacturaNavigation)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdFacturasIdFactura);

                entity.HasOne(d => d.IdFederalizacion)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdFederalizacionid);

                entity.HasOne(d => d.IdInventarios)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdInventariosid);

                entity.HasOne(d => d.IdProveedor)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdProveedorid);

                entity.HasOne(d => d.IdResguardatarios)
                    .WithMany(p => p.TblBienesSistemas)
                    .HasForeignKey(d => d.IdResguardatariosid);
            });

            modelBuilder.Entity<TblClaveCambs>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Clavecambs).HasColumnName("clavecambs");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblClaveCambs)
                    .HasForeignKey(d => d.CatTipoDeBienId);
            });

            modelBuilder.Entity<TblClaveSaica>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Clavesaica).HasColumnName("clavesaica");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblClaveSaica)
                    .HasForeignKey(d => d.CatTipoDeBienId);
            });

            modelBuilder.Entity<TblConfPerfil>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.IdPermisoid);

                entity.HasIndex(e => e.IdRolid);

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.IdPermiso)
                    .WithMany()
                    .HasForeignKey(d => d.IdPermisoid);

                entity.HasOne(d => d.IdRol)
                    .WithMany()
                    .HasForeignKey(d => d.IdRolid);
            });

            modelBuilder.Entity<TblContratoBien>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Contratobien).HasColumnName("contratobien");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblContratoBien)
                    .HasForeignKey(d => d.CatTipoDeBienId);
            });

            modelBuilder.Entity<TblFacturas>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.HasIndex(e => e.CatTipoDeBienId);

               

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.CostoTotal).HasColumnName("costoTotal");

                entity.Property(e => e.Factura).HasColumnName("factura");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.Subtotal).HasColumnName("subtotal");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblFacturas)
                    .HasForeignKey(d => d.CatTipoDeBienId);

        
            });

            modelBuilder.Entity<TblFederalizacion>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.Federalizacion).HasColumnName("federalizacion");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblFederalizacion)
                    .HasForeignKey(d => d.CatTipoDeBienId);
            });

            modelBuilder.Entity<TblInstrumentalMedico>(entity =>
            {
                entity.HasIndex(e => e.CatEstadoDelBienid);

                entity.HasIndex(e => e.CatGarantiaid);

                entity.HasIndex(e => e.CatPisosid);

                entity.HasIndex(e => e.CatTipoDeBienesCatTipoDeBienId);

                entity.HasIndex(e => e.CatTipoEntradaid);

                entity.HasIndex(e => e.CatTipoPartidaid);

                entity.HasIndex(e => e.IdAreaServicioid);

                entity.HasIndex(e => e.IdClaveCambsid);

                entity.HasIndex(e => e.IdClaveSaicaid);

                entity.HasIndex(e => e.IdContratoBienid);

                entity.HasIndex(e => e.IdFacturasIdFactura);

                entity.HasIndex(e => e.IdFederalizacionid);

                entity.HasIndex(e => e.IdInventariosid);

                entity.HasIndex(e => e.IdProveedorid);

                entity.HasIndex(e => e.IdResguardatariosid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CatEstadoDelBienid).HasColumnName("catEstadoDelBienid");

                entity.Property(e => e.CatGarantiaid).HasColumnName("catGarantiaid");

                entity.Property(e => e.CatPisosid).HasColumnName("catPisosid");

                entity.Property(e => e.CatTipoDeBienesCatTipoDeBienId).HasColumnName("catTipoDeBienesCatTipoDeBienId");

                entity.Property(e => e.CatTipoEntradaid).HasColumnName("catTipoEntradaid");

                entity.Property(e => e.CatTipoPartidaid).HasColumnName("catTipoPartidaid");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Serie).HasColumnName("serie");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatEstadoDelBien)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.CatEstadoDelBienid);

                entity.HasOne(d => d.CatGarantia)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.CatGarantiaid);

                entity.HasOne(d => d.CatPisos)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.CatPisosid);

                entity.HasOne(d => d.CatTipoDeBienesCatTipoDeBien)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.CatTipoDeBienesCatTipoDeBienId)
                    .HasConstraintName("FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~");

                entity.HasOne(d => d.CatTipoEntrada)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.CatTipoEntradaid);

                entity.HasOne(d => d.CatTipoPartida)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.CatTipoPartidaid);

                entity.HasOne(d => d.IdAreaServicio)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdAreaServicioid);

                entity.HasOne(d => d.IdClaveCambs)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdClaveCambsid);

                entity.HasOne(d => d.IdClaveSaica)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdClaveSaicaid);

                entity.HasOne(d => d.IdContratoBien)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdContratoBienid);

                entity.HasOne(d => d.IdFacturasIdFacturaNavigation)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdFacturasIdFactura);

                entity.HasOne(d => d.IdFederalizacion)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdFederalizacionid);

                entity.HasOne(d => d.IdInventarios)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdInventariosid);

                entity.HasOne(d => d.IdProveedor)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdProveedorid);

                entity.HasOne(d => d.IdResguardatarios)
                    .WithMany(p => p.TblInstrumentalMedico)
                    .HasForeignKey(d => d.IdResguardatariosid);
            });

            modelBuilder.Entity<TblInventarios>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblInventarios)
                    .HasForeignKey(d => d.CatTipoDeBienId);
            });

            modelBuilder.Entity<TblProveedor>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Proveedor).HasColumnName("proveedor");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblProveedor)
                    .HasForeignKey(d => d.CatTipoDeBienId);
            });

            modelBuilder.Entity<TblResguardatarios>(entity =>
            {
                entity.HasIndex(e => e.CatEstatusid);

                entity.HasIndex(e => e.CatServicioid);

                entity.HasIndex(e => e.CatSexoid);

                entity.HasIndex(e => e.CatTipoContratoid);

                entity.HasIndex(e => e.CatTurnoid);

                entity.HasIndex(e => e.TblAreaServicioid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.ApellidoDos).HasColumnName("apellidoDos");

                entity.Property(e => e.ApellidoUno).HasColumnName("apellidoUno");

                entity.Property(e => e.Cargo).HasColumnName("cargo");

                entity.Property(e => e.CatEstatusid).HasColumnName("catEstatusid");

                entity.Property(e => e.CatSexoid).HasColumnName("catSexoid");

                entity.Property(e => e.CatTipoContratoid).HasColumnName("catTipoContratoid");

                entity.Property(e => e.CatTurnoid).HasColumnName("catTurnoid");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Numeroempleado).HasColumnName("numeroempleado");

                entity.Property(e => e.Plaza).HasColumnName("plaza");

                entity.Property(e => e.Rfc).HasColumnName("RFC");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatEstatus)
                    .WithMany(p => p.TblResguardatarios)
                    .HasForeignKey(d => d.CatEstatusid);

                entity.HasOne(d => d.CatServicio)
                    .WithMany(p => p.TblResguardatarios)
                    .HasForeignKey(d => d.CatServicioid);

                entity.HasOne(d => d.CatSexo)
                    .WithMany(p => p.TblResguardatarios)
                    .HasForeignKey(d => d.CatSexoid);

                entity.HasOne(d => d.CatTipoContrato)
                    .WithMany(p => p.TblResguardatarios)
                    .HasForeignKey(d => d.CatTipoContratoid);

                entity.HasOne(d => d.CatTurno)
                    .WithMany(p => p.TblResguardatarios)
                    .HasForeignKey(d => d.CatTurnoid);

                entity.HasOne(d => d.TblAreaServicio)
                    .WithMany(p => p.TblResguardatarios)
                    .HasForeignKey(d => d.TblAreaServicioid);
            });

            modelBuilder.Entity<TblSalidas>(entity =>
            {
                entity.HasIndex(e => e.CatTipoDeBienId);

                entity.HasIndex(e => e.CatTipoSalidaid);

                entity.HasIndex(e => e.CatUnidadDestinoid);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdBien).HasColumnName("IdBien");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.CatTipoSalidaid).HasColumnName("catTipoSalidaid");

                entity.Property(e => e.CatUnidadDestinoid).HasColumnName("catUnidadDestinoid");

                entity.Property(e => e.FechaAlta).HasColumnName("fechaAlta");

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");

                entity.Property(e => e.UsuarioMod).HasColumnName("usuarioMod");

                entity.HasOne(d => d.CatTipoDeBien)
                    .WithMany(p => p.TblSalidas)
                    .HasForeignKey(d => d.CatTipoDeBienId);

                entity.HasOne(d => d.CatTipoSalida)
                    .WithMany(p => p.TblSalidas)
                    .HasForeignKey(d => d.CatTipoSalidaid);

                entity.HasOne(d => d.CatUnidadDestino)
                    .WithMany(p => p.TblSalidas)
                    .HasForeignKey(d => d.CatUnidadDestinoid);



            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
