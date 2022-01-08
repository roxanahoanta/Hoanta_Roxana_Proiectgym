﻿// <auto-generated />
using System;
using Hoanta_Roxana_Proiectgym.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hoanta_Roxana_Proiectgym.Migrations
{
    [DbContext(typeof(Hoanta_Roxana_ProiectgymContext))]
    [Migration("20220104161756_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hoanta_Roxana_Proiectgym.Models.Abonament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AntrenorID")
                        .HasColumnType("int");

                    b.Property<int>("CursID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCreareAbonament")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AntrenorID");

                    b.HasIndex("CursID");

                    b.ToTable("Abonament");
                });

            modelBuilder.Entity("Hoanta_Roxana_Proiectgym.Models.Antrenor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeAntrenor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenumeAntrenor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ziua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Antrenor");
                });

            modelBuilder.Entity("Hoanta_Roxana_Proiectgym.Models.Curs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DenumireCurs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dificultate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Curs");
                });

            modelBuilder.Entity("Hoanta_Roxana_Proiectgym.Models.Abonament", b =>
                {
                    b.HasOne("Hoanta_Roxana_Proiectgym.Models.Antrenor", "Antrenor")
                        .WithMany("Abonamente")
                        .HasForeignKey("AntrenorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hoanta_Roxana_Proiectgym.Models.Curs", "Curs")
                        .WithMany("Abonamente")
                        .HasForeignKey("CursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Antrenor");

                    b.Navigation("Curs");
                });

            modelBuilder.Entity("Hoanta_Roxana_Proiectgym.Models.Antrenor", b =>
                {
                    b.Navigation("Abonamente");
                });

            modelBuilder.Entity("Hoanta_Roxana_Proiectgym.Models.Curs", b =>
                {
                    b.Navigation("Abonamente");
                });
#pragma warning restore 612, 618
        }
    }
}