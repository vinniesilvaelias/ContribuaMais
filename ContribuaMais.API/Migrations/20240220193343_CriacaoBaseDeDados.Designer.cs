﻿// <auto-generated />
using System;
using ContribuaMais.API.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContribuaMais.API.Migrations
{
    [DbContext(typeof(ContribuaMaisContexto))]
    [Migration("20240220193343_CriacaoBaseDeDados")]
    partial class CriacaoBaseDeDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContribuaMais.API.Models.Dados.Campanha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Arrecadado")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstaAtiva")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Objetivo")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2,2)");

                    b.HasKey("Id");

                    b.ToTable("Campanhas");
                });

            modelBuilder.Entity("ContribuaMais.API.Models.Dados.Doacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CampanhaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<Guid>("DoadorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("FoiEfetivada")
                        .HasColumnType("bit");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.HasIndex("DoadorId");

                    b.HasIndex("ItemId");

                    b.ToTable("Doacoes");
                });

            modelBuilder.Entity("ContribuaMais.API.Models.Dados.Doador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doadores");
                });

            modelBuilder.Entity("ContribuaMais.API.Models.Dados.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Decricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("ContribuaMais.API.Models.Dados.ProjetoSocial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjetoSocials");
                });

            modelBuilder.Entity("ContribuaMais.API.Models.Dados.Doacao", b =>
                {
                    b.HasOne("ContribuaMais.API.Models.Dados.Campanha", "Campanha")
                        .WithMany()
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContribuaMais.API.Models.Dados.Doador", "Doador")
                        .WithMany()
                        .HasForeignKey("DoadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContribuaMais.API.Models.Dados.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");

                    b.Navigation("Doador");

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
