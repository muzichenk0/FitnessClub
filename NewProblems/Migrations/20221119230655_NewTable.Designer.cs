﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewProblems.Contexts;

#nullable disable

namespace NewProblems.Migrations
{
    [DbContext(typeof(UsersContext))]
    [Migration("20221119230655_NewTable")]
    partial class NewTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NewProblems.Models.Coaches", b =>
                {
                    b.Property<int>("CoachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CoachName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InOurGymFrom")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialistIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearsInStudyPractise")
                        .HasColumnType("int");

                    b.HasKey("CoachId");

                    b.ToTable("Coaches");

                    b.HasData(
                        new
                        {
                            CoachId = 1,
                            Age = 53,
                            CoachName = "Igor",
                            Gender = "Helicopter",
                            InOurGymFrom = new DateTime(2022, 11, 20, 2, 6, 54, 802, DateTimeKind.Local).AddTicks(5642),
                            SpecialistIn = "Hight weight tooks up",
                            YearsInStudyPractise = 23
                        });
                });

            modelBuilder.Entity("NewProblems.Models.CoachInvites", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CoachName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfPostMan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CoachInvites");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CoachName = "He",
                            RequestStatus = "E"
                        });
                });

            modelBuilder.Entity("NewProblems.Models.TrainingsList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ActionsPerRepeat")
                        .HasColumnType("int");

                    b.Property<string>("CoachName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedForWho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Repeats")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfExcersice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TrainingsList");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActionsPerRepeat = 23,
                            CoachName = "Igor",
                            CreatedForWho = "owner",
                            Repeats = 2,
                            TypeOfExcersice = "Push Ups"
                        });
                });

            modelBuilder.Entity("NewProblems.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permissions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Login = "owner",
                            Password = "owner",
                            Permissions = "Administrator"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}