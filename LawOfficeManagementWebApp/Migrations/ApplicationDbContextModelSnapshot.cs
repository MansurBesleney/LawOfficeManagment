﻿// <auto-generated />
using System;
using LawOfficeManagementWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LawOfficeManagementWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientLawyer", b =>
                {
                    b.Property<Guid>("ClientsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LawyersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClientsId", "LawyersId");

                    b.HasIndex("LawyersId");

                    b.ToTable("ClientLawyer");
                });

            modelBuilder.Entity("LawOfficeManagementWebApp.Models.Entites.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"), false);

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("LawOfficeManagementWebApp.Models.Entites.Lawyer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"), false);

                    b.ToTable("Lawyers");
                });

            modelBuilder.Entity("ClientLawyer", b =>
                {
                    b.HasOne("LawOfficeManagementWebApp.Models.Entites.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LawOfficeManagementWebApp.Models.Entites.Lawyer", null)
                        .WithMany()
                        .HasForeignKey("LawyersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
