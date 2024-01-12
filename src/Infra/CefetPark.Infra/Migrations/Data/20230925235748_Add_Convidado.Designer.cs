﻿// <auto-generated />
using System;
using CefetPark.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CefetPark.Infra.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    [Migration("20230925235748_Add_Convidado")]
    partial class Add_Convidado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarroConvidado", b =>
                {
                    b.Property<int>("CarrosId")
                        .HasColumnType("int");

                    b.Property<int>("ConvidadosId")
                        .HasColumnType("int");

                    b.HasKey("CarrosId", "ConvidadosId");

                    b.HasIndex("ConvidadosId");

                    b.ToTable("CarroConvidado");
                });

            modelBuilder.Entity("CarroUsuario", b =>
                {
                    b.Property<int>("CarrosId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("CarrosId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("CarroUsuario");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("Cor_Id")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Modelo_Id")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Cor_Id");

                    b.HasIndex("Modelo_Id");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Convidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Convidado");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Cor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Cores");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("char(8)")
                        .IsFixedLength();

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Estacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Endereco_Id")
                        .HasColumnType("int");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("QtdVagasLivres")
                        .HasColumnType("int");

                    b.Property<int>("QtdVagasTotal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Endereco_Id")
                        .IsUnique();

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Estacionamentos");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Marca_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Marca_Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.RegistroEntradaSaida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("Carro_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Convidado_Id")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataSaida")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Estacionamento_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Carro_Id");

                    b.HasIndex("Convidado_Id");

                    b.HasIndex("Estacionamento_Id");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("RegistrosEntradasSaidas");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.TipoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("TiposUsuarios");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AspNetUsers_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("AtualizadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)")
                        .IsFixedLength();

                    b.Property<int>("CriadoPor")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Departamento_Id")
                        .HasColumnType("int");

                    b.Property<string>("EmailPrincipal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmailSecundario")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TelefonePrincipal")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("TelefoneSecundario")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("TipoUsuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Departamento_Id");

                    b.HasIndex("Matricula")
                        .IsUnique();

                    b.HasIndex("TipoUsuario_Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CarroConvidado", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Carro", null)
                        .WithMany()
                        .HasForeignKey("CarrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CefetPark.Domain.Entidades.Convidado", null)
                        .WithMany()
                        .HasForeignKey("ConvidadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarroUsuario", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Carro", null)
                        .WithMany()
                        .HasForeignKey("CarrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CefetPark.Domain.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Carro", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Cor", "Cor")
                        .WithMany("Carros")
                        .HasForeignKey("Cor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CefetPark.Domain.Entidades.Modelo", "Modelo")
                        .WithMany("Carros")
                        .HasForeignKey("Modelo_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cor");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Estacionamento", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Endereco", "Endereco")
                        .WithOne("Estacionamento")
                        .HasForeignKey("CefetPark.Domain.Entidades.Estacionamento", "Endereco_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Modelo", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("Marca_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.RegistroEntradaSaida", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Carro", "Carro")
                        .WithMany("RegistrosEntradasSaidas")
                        .HasForeignKey("Carro_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CefetPark.Domain.Entidades.Convidado", "Convidado")
                        .WithMany("RegistroEntradaSaidas")
                        .HasForeignKey("Convidado_Id");

                    b.HasOne("CefetPark.Domain.Entidades.Estacionamento", "Estacionamento")
                        .WithMany("RegistrosEntradasSaidas")
                        .HasForeignKey("Estacionamento_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CefetPark.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("RegistrosEntradasSaidas")
                        .HasForeignKey("Usuario_Id");

                    b.Navigation("Carro");

                    b.Navigation("Convidado");

                    b.Navigation("Estacionamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Usuario", b =>
                {
                    b.HasOne("CefetPark.Domain.Entidades.Departamento", "Departamento")
                        .WithMany("Usuarios")
                        .HasForeignKey("Departamento_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CefetPark.Domain.Entidades.TipoUsuario", "TipoUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoUsuario_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Carro", b =>
                {
                    b.Navigation("RegistrosEntradasSaidas");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Convidado", b =>
                {
                    b.Navigation("RegistroEntradaSaidas");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Cor", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Departamento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Endereco", b =>
                {
                    b.Navigation("Estacionamento")
                        .IsRequired();
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Estacionamento", b =>
                {
                    b.Navigation("RegistrosEntradasSaidas");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Marca", b =>
                {
                    b.Navigation("Modelos");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Modelo", b =>
                {
                    b.Navigation("Carros");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("CefetPark.Domain.Entidades.Usuario", b =>
                {
                    b.Navigation("RegistrosEntradasSaidas");
                });
#pragma warning restore 612, 618
        }
    }
}