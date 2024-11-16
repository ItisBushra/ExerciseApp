﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20241116131821_RequestWorkoutMigration")]
    partial class RequestWorkoutMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.WorkoutGenerateRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Equipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FitnessLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Goal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkoutGenerateRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Equipment = "None",
                            FitnessLevel = "Beginner",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 2,
                            Equipment = "None",
                            FitnessLevel = "Intermediate",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 3,
                            Equipment = "None",
                            FitnessLevel = "Advanced",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 4,
                            Equipment = "TreadMill",
                            FitnessLevel = "Beginner",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 5,
                            Equipment = "TreadMill",
                            FitnessLevel = "Intermediate",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 6,
                            Equipment = "TreadMill",
                            FitnessLevel = "Advanced",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 7,
                            Equipment = "Bands",
                            FitnessLevel = "Beginner",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 8,
                            Equipment = "Bands",
                            FitnessLevel = "Intermediate",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 9,
                            Equipment = "Bands",
                            FitnessLevel = "Advanced",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 10,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Beginner",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 11,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Intermediate",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 12,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Advanced",
                            Goal = "BuildMuscles"
                        },
                        new
                        {
                            Id = 13,
                            Equipment = "None",
                            FitnessLevel = "Beginner",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 14,
                            Equipment = "None",
                            FitnessLevel = "Intermediate",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 15,
                            Equipment = "None",
                            FitnessLevel = "Advanced",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 16,
                            Equipment = "TreadMill",
                            FitnessLevel = "Beginner",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 17,
                            Equipment = "TreadMill",
                            FitnessLevel = "Intermediate",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 18,
                            Equipment = "TreadMill",
                            FitnessLevel = "Advanced",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 19,
                            Equipment = "Bands",
                            FitnessLevel = "Beginner",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 20,
                            Equipment = "Bands",
                            FitnessLevel = "Intermediate",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 21,
                            Equipment = "Bands",
                            FitnessLevel = "Advanced",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 22,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Beginner",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 23,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Intermediate",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 24,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Advanced",
                            Goal = "LoseWeight"
                        },
                        new
                        {
                            Id = 25,
                            Equipment = "None",
                            FitnessLevel = "Beginner",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 26,
                            Equipment = "None",
                            FitnessLevel = "Intermediate",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 27,
                            Equipment = "None",
                            FitnessLevel = "Advanced",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 28,
                            Equipment = "TreadMill",
                            FitnessLevel = "Beginner",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 29,
                            Equipment = "TreadMill",
                            FitnessLevel = "Intermediate",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 30,
                            Equipment = "TreadMill",
                            FitnessLevel = "Advanced",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 31,
                            Equipment = "Bands",
                            FitnessLevel = "Beginner",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 32,
                            Equipment = "Bands",
                            FitnessLevel = "Intermediate",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 33,
                            Equipment = "Bands",
                            FitnessLevel = "Advanced",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 34,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Beginner",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 35,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Intermediate",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 36,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Advanced",
                            Goal = "IncreaseEndurance"
                        },
                        new
                        {
                            Id = 37,
                            Equipment = "None",
                            FitnessLevel = "Beginner",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 38,
                            Equipment = "None",
                            FitnessLevel = "Intermediate",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 39,
                            Equipment = "None",
                            FitnessLevel = "Advanced",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 40,
                            Equipment = "TreadMill",
                            FitnessLevel = "Beginner",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 41,
                            Equipment = "TreadMill",
                            FitnessLevel = "Intermediate",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 42,
                            Equipment = "TreadMill",
                            FitnessLevel = "Advanced",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 43,
                            Equipment = "Bands",
                            FitnessLevel = "Beginner",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 44,
                            Equipment = "Bands",
                            FitnessLevel = "Intermediate",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 45,
                            Equipment = "Bands",
                            FitnessLevel = "Advanced",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 46,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Beginner",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 47,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Intermediate",
                            Goal = "ImproveFlexibility"
                        },
                        new
                        {
                            Id = 48,
                            Equipment = "WeightMachines",
                            FitnessLevel = "Advanced",
                            Goal = "ImproveFlexibility"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
