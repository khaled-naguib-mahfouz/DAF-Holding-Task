﻿// <auto-generated />
using System;
using DAF_Holding_Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAF_Holding_Task.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241108062217_seedingData")]
    partial class seedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAF_Holding_Task.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DatePosted")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserProfileID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileID");

                    b.ToTable("posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Content of John's first post.",
                            DatePosted = new DateOnly(2024, 1, 1),
                            Title = "John's First Post",
                            UserProfileID = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Content of John's second post.",
                            DatePosted = new DateOnly(2024, 1, 5),
                            Title = "John's Second Post",
                            UserProfileID = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Content of Jane's first post.",
                            DatePosted = new DateOnly(2024, 2, 10),
                            Title = "Jane's First Post",
                            UserProfileID = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Content of Alice's first post.",
                            DatePosted = new DateOnly(2024, 3, 15),
                            Title = "Alice's First Post",
                            UserProfileID = 3
                        },
                        new
                        {
                            Id = 5,
                            Content = "Content of Alice's second post.",
                            DatePosted = new DateOnly(2024, 3, 20),
                            Title = "Alice's Second Post",
                            UserProfileID = 3
                        });
                });

            modelBuilder.Entity("DAF_Holding_Task.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("userProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateOnly(1990, 1, 1),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateOnly(1985, 2, 10),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateOnly(1992, 3, 15),
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateOnly(1993, 4, 20),
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateOnly(1987, 5, 25),
                            Email = "carol.white@example.com",
                            FirstName = "Carol",
                            LastName = "White"
                        });
                });

            modelBuilder.Entity("DAF_Holding_Task.Models.Post", b =>
                {
                    b.HasOne("DAF_Holding_Task.Models.UserProfile", "UserProfile")
                        .WithMany("posts")
                        .HasForeignKey("UserProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("DAF_Holding_Task.Models.UserProfile", b =>
                {
                    b.Navigation("posts");
                });
#pragma warning restore 612, 618
        }
    }
}
