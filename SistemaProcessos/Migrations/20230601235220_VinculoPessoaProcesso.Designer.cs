﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaProcessos.Data;

#nullable disable

namespace SistemaProcessos.Migrations
{
    [DbContext(typeof(SistemaProcessosDBContext))]
    [Migration("20230601235220_VinculoPessoaProcesso")]
    partial class VinculoPessoaProcesso
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SistemaProcessos.Models.PessoasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Cliente")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cpf_cnpj")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("SistemaProcessos.Models.ProcessosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Advogado_id")
                        .HasColumnType("int");

                    b.Property<bool>("Arquivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Cliente_id")
                        .HasColumnType("int");

                    b.Property<string>("Numero_processo")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar(35)");

                    b.Property<DateTime>("Proximo_prazo")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Advogado_id");

                    b.ToTable("Processos");
                });

            modelBuilder.Entity("SistemaProcessos.Models.ProcessosModel", b =>
                {
                    b.HasOne("SistemaProcessos.Models.PessoasModel", null)
                        .WithMany()
                        .HasForeignKey("Advogado_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}