﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestingProject.Models;

namespace TestingProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190621160908_testinG")]
    partial class testinG
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestingProject.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TestingProject.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TestingProject.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.HasIndex("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestingProject.Models.Subject", b =>
                {
                    b.HasOne("TestingProject.Models.User")
                        .WithMany("Subjects")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TestingProject.Models.User", b =>
                {
                    b.HasOne("TestingProject.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
