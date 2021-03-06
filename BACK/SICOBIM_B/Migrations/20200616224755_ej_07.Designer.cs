﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;


namespace SICOBIM_B.Migrations
{
    [DbContext(typeof(sicobimContext))]
    [Migration("20200616224755_ej_07")]
    partial class ej_07
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SICOBIM_B.Entities.CatEstadoDelBien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatEstadoDelBien");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatEstatus", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<string>("estatus")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatEstatus");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatRol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("UsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("rol")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("catRol");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatServicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("servicio")
                        .HasColumnType("text");

                    b.Property<int>("usuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatServicio");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatSexo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<string>("sexo")
                        .HasColumnType("text");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatSexo");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatTipoContrato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<string>("contrato")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatTipoContrato");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatTipoDeBienes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TipodeBien")
                        .HasColumnType("text");

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatTipoDeBien");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.CatTurno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<string>("turno")
                        .HasColumnType("text");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("CatTurno");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.TblBienes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("IVA")
                        .HasColumnType("double precision");

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<int?>("catEstadoDelBienid")
                        .HasColumnType("integer");

                    b.Property<int?>("catTipoDeBienesid")
                        .HasColumnType("integer");

                    b.Property<int?>("cat_Horarioid")
                        .HasColumnType("integer");

                    b.Property<string>("claveCambs")
                        .HasColumnType("text");

                    b.Property<string>("claveSaica")
                        .HasColumnType("text");

                    b.Property<double>("costoTotal")
                        .HasColumnType("double precision");

                    b.Property<string>("descripcion")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idEstadoFisico")
                        .HasColumnType("integer");

                    b.Property<int>("idFactura")
                        .HasColumnType("integer");

                    b.Property<int>("idResguardatario")
                        .HasColumnType("integer");

                    b.Property<int>("idServicio")
                        .HasColumnType("integer");

                    b.Property<int>("idTipoBien")
                        .HasColumnType("integer");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<string>("marca")
                        .HasColumnType("text");

                    b.Property<string>("modelo")
                        .HasColumnType("text");

                    b.Property<int>("numeroInventario")
                        .HasColumnType("integer");

                    b.Property<string>("serie")
                        .HasColumnType("text");

                    b.Property<int?>("tblResguardatariosid")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("catEstadoDelBienid");

                    b.HasIndex("catTipoDeBienesid");

                    b.HasIndex("cat_Horarioid");

                    b.HasIndex("tblResguardatariosid");

                    b.ToTable("TblBienes");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.TblResguardatarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CatServicioid")
                        .HasColumnType("integer");

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<string>("apellidoDos")
                        .HasColumnType("text");

                    b.Property<string>("apellidoUno")
                        .HasColumnType("text");

                    b.Property<int?>("catEstatusid")
                        .HasColumnType("integer");

                    b.Property<int?>("catTipoContratoid")
                        .HasColumnType("integer");

                    b.Property<int?>("catTurnoid")
                        .HasColumnType("integer");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idEstatus")
                        .HasColumnType("integer");

                    b.Property<int>("idServicio")
                        .HasColumnType("integer");

                    b.Property<int>("idTipoContrato")
                        .HasColumnType("integer");

                    b.Property<int>("idTurno")
                        .HasColumnType("integer");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("CatServicioid");

                    b.HasIndex("catEstatusid");

                    b.HasIndex("catTipoContratoid");

                    b.HasIndex("catTurnoid");

                    b.ToTable("TblResguardatarios");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CatServicioid")
                        .HasColumnType("integer");

                    b.Property<int?>("CatTipoDeBienesid")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.Property<bool>("activo")
                        .HasColumnType("boolean");

                    b.Property<int?>("catRolid")
                        .HasColumnType("integer");

                    b.Property<int?>("catSexoid")
                        .HasColumnType("integer");

                    b.Property<int?>("cat_horarioid")
                        .HasColumnType("integer");

                    b.Property<string>("correo")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("idRol")
                        .HasColumnType("integer");

                    b.Property<int>("idServicio")
                        .HasColumnType("integer");

                    b.Property<int>("idSexo")
                        .HasColumnType("integer");

                    b.Property<int>("idTipoBien")
                        .HasColumnType("integer");

                    b.Property<int>("idUsuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("CatServicioid");

                    b.HasIndex("CatTipoDeBienesid");

                    b.HasIndex("catRolid");

                    b.HasIndex("catSexoid");

                    b.HasIndex("cat_horarioid");

                    b.ToTable("CtrlUsuarios");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.cat_horario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechaMod")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("horario")
                        .HasColumnType("text");

                    b.Property<int>("usuarioAlta")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioMod")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("cat_horario");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.TblBienes", b =>
                {
                    b.HasOne("SICOBIM_B.Entities.CatEstadoDelBien", "catEstadoDelBien")
                        .WithMany("tblBienes")
                        .HasForeignKey("catEstadoDelBienid");

                    b.HasOne("SICOBIM_B.Entities.CatTipoDeBienes", "catTipoDeBienes")
                        .WithMany("tblBienes")
                        .HasForeignKey("catTipoDeBienesid");

                    b.HasOne("SICOBIM_B.Entities.cat_horario", "cat_Horario")
                        .WithMany()
                        .HasForeignKey("cat_Horarioid");

                    b.HasOne("SICOBIM_B.Entities.TblResguardatarios", "tblResguardatarios")
                        .WithMany("tblBienes")
                        .HasForeignKey("tblResguardatariosid");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.TblResguardatarios", b =>
                {
                    b.HasOne("SICOBIM_B.Entities.CatServicio", "CatServicio")
                        .WithMany("tblResguardatarios")
                        .HasForeignKey("CatServicioid");

                    b.HasOne("SICOBIM_B.Entities.CatEstatus", "catEstatus")
                        .WithMany("tblResguardatarios")
                        .HasForeignKey("catEstatusid");

                    b.HasOne("SICOBIM_B.Entities.CatTipoContrato", "catTipoContrato")
                        .WithMany("tblResguardatarios")
                        .HasForeignKey("catTipoContratoid");

                    b.HasOne("SICOBIM_B.Entities.CatTurno", "catTurno")
                        .WithMany("tblResguardatarios")
                        .HasForeignKey("catTurnoid");
                });

            modelBuilder.Entity("SICOBIM_B.Entities.User", b =>
                {
                    b.HasOne("SICOBIM_B.Entities.CatServicio", "CatServicio")
                        .WithMany("users")
                        .HasForeignKey("CatServicioid");

                    b.HasOne("SICOBIM_B.Entities.CatTipoDeBienes", "CatTipoDeBienes")
                        .WithMany("users")
                        .HasForeignKey("CatTipoDeBienesid");

                    b.HasOne("SICOBIM_B.Entities.CatRol", "catRol")
                        .WithMany()
                        .HasForeignKey("catRolid");

                    b.HasOne("SICOBIM_B.Entities.CatSexo", "catSexo")
                        .WithMany("users")
                        .HasForeignKey("catSexoid");

                    b.HasOne("SICOBIM_B.Entities.cat_horario", null)
                        .WithMany("users")
                        .HasForeignKey("cat_horarioid");
                });
#pragma warning restore 612, 618
        }
    }
}
