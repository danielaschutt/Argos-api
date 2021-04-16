﻿// <auto-generated />
using System;
using Argos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Argos.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Argos.Domain.AlertaProvidenciaRoot.AlertaProvidencia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("AlertaId")
                        .HasColumnName("alerta_id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("AlertaId")
                        .IsUnique();

                    b.ToTable("alerta_providencia");
                });

            modelBuilder.Entity("Argos.Domain.AlertaRoot.Alerta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Area")
                        .HasColumnName("area")
                        .HasMaxLength(500);

                    b.Property<long>("CidadeId")
                        .HasColumnName("cidade_id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnName("placa")
                        .HasMaxLength(10);

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.Property<long>("TipoId")
                        .HasColumnName("tipo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasMaxLength(150);

                    b.Property<long?>("UsuarioId")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("TipoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("alertas");
                });

            modelBuilder.Entity("Argos.Domain.CameraLogRoot.CameraLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("AlertaId")
                        .HasColumnName("alerta_id");

                    b.Property<long>("CameraId")
                        .HasColumnName("camera_id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<DateTime>("Data")
                        .HasColumnName("data_deteccao");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("AlertaId");

                    b.HasIndex("CameraId");

                    b.ToTable("log_camera");
                });

            modelBuilder.Entity("Argos.Domain.CameraRoot.Camera", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<double>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnName("longitude");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(150);

                    b.Property<bool>("Status")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("cameras");
                });

            modelBuilder.Entity("Argos.Domain.CidadeRoot.Cidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<long>("EstadoId")
                        .HasColumnName("estado_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("cidades");
                });

            modelBuilder.Entity("Argos.Domain.DispositivoRoot.Dispositivo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("codigo_identificacao")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<long>("UsuarioId")
                        .HasColumnName("usuario_id");

                    b.Property<string>("Versao")
                        .IsRequired()
                        .HasColumnName("versao")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("dispositivos");
                });

            modelBuilder.Entity("Argos.Domain.EstadoRoot.Estado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("estados");
                });

            modelBuilder.Entity("Argos.Domain.TipoAlertaRoot.TipoAlerta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("tipos_alerta");
                });

            modelBuilder.Entity("Argos.Domain.TipoUsuarioRoot.TipoUsuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("tipo_usuario");
                });

            modelBuilder.Entity("Argos.Domain.UsuarioPosicaoRoot.UsuarioPosicao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<double>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnName("longitude");

                    b.Property<long>("UsuarioId")
                        .HasColumnName("usuario_id");

                    b.Property<long?>("UsuarioId1");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.HasIndex("UsuarioId1");

                    b.ToTable("usuario_posicao");
                });

            modelBuilder.Entity("Argos.Domain.UsuarioRoot.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf")
                        .HasMaxLength(15);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnName("criado_em");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(100);

                    b.Property<bool>("IsRevoked")
                        .HasColumnName("is_revoked");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnName("matricula")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(100);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnName("password_hash")
                        .HasMaxLength(100);

                    b.Property<long>("TipoId")
                        .HasColumnName("tipo_id");

                    b.Property<string>("TokenFirebase")
                        .HasColumnName("token_firebase")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Argos.Domain.AlertaProvidenciaRoot.AlertaProvidencia", b =>
                {
                    b.HasOne("Argos.Domain.AlertaRoot.Alerta", "Alerta")
                        .WithOne()
                        .HasForeignKey("Argos.Domain.AlertaProvidenciaRoot.AlertaProvidencia", "AlertaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Argos.Domain.AlertaRoot.Alerta", b =>
                {
                    b.HasOne("Argos.Domain.CidadeRoot.Cidade", "Cidade")
                        .WithMany("Alertas")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Argos.Domain.TipoAlertaRoot.TipoAlerta", "Tipo")
                        .WithMany("Alertas")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Argos.Domain.UsuarioRoot.Usuario", "Usuario")
                        .WithMany("Alertas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Argos.Domain.CameraLogRoot.CameraLog", b =>
                {
                    b.HasOne("Argos.Domain.AlertaRoot.Alerta", "Alerta")
                        .WithMany("Logs")
                        .HasForeignKey("AlertaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Argos.Domain.CameraRoot.Camera", "Camera")
                        .WithMany("Log")
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Argos.Domain.CidadeRoot.Cidade", b =>
                {
                    b.HasOne("Argos.Domain.EstadoRoot.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Argos.Domain.DispositivoRoot.Dispositivo", b =>
                {
                    b.HasOne("Argos.Domain.UsuarioRoot.Usuario", "Usuario")
                        .WithMany("Dispositivos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Argos.Domain.UsuarioPosicaoRoot.UsuarioPosicao", b =>
                {
                    b.HasOne("Argos.Domain.UsuarioRoot.Usuario", "Usuario")
                        .WithOne()
                        .HasForeignKey("Argos.Domain.UsuarioPosicaoRoot.UsuarioPosicao", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Argos.Domain.UsuarioRoot.Usuario")
                        .WithMany("Posicoes")
                        .HasForeignKey("UsuarioId1");
                });

            modelBuilder.Entity("Argos.Domain.UsuarioRoot.Usuario", b =>
                {
                    b.HasOne("Argos.Domain.TipoUsuarioRoot.TipoUsuario", "Tipo")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
