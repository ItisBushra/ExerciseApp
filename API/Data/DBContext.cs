using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {
            
        }
        public DbSet<WorkoutGenerateRequest> WorkoutGenerateRequests { get; set; }
        public DbSet<WorkoutGenerateResponse> WorkoutGenerateResponses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-to-One
            modelBuilder.Entity<WorkoutGenerateRequest>()
                .HasOne(b => b.WorkoutGenerateResponse)
                .WithOne(rt => rt.WorkoutGenerateRequest)
                .HasForeignKey<WorkoutGenerateResponse>(rt => rt.WorkoutGenerateRequestId);

            modelBuilder.Entity<WorkoutGenerateRequest>().HasData(
                new WorkoutGenerateRequest { Id = 1, Goal = "BuildMuscles", Equipment = "None", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 2, Goal = "BuildMuscles", Equipment = "None", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 3, Goal = "BuildMuscles", Equipment = "None", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 4, Goal = "BuildMuscles", Equipment = "TreadMill", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 5, Goal = "BuildMuscles", Equipment = "TreadMill", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 6, Goal = "BuildMuscles", Equipment = "TreadMill", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 7, Goal = "BuildMuscles", Equipment = "Bands", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 8, Goal = "BuildMuscles", Equipment = "Bands", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 9, Goal = "BuildMuscles", Equipment = "Bands", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 10, Goal = "BuildMuscles", Equipment = "WeightMachines", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 11, Goal = "BuildMuscles", Equipment = "WeightMachines", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 12, Goal = "BuildMuscles", Equipment = "WeightMachines", FitnessLevel = "Advanced" },

                new WorkoutGenerateRequest { Id = 13, Goal = "LoseWeight", Equipment = "None", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 14, Goal = "LoseWeight", Equipment = "None", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 15, Goal = "LoseWeight", Equipment = "None", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 16, Goal = "LoseWeight", Equipment = "TreadMill", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 17, Goal = "LoseWeight", Equipment = "TreadMill", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 18, Goal = "LoseWeight", Equipment = "TreadMill", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 19, Goal = "LoseWeight", Equipment = "Bands", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 20, Goal = "LoseWeight", Equipment = "Bands", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 21, Goal = "LoseWeight", Equipment = "Bands", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 22, Goal = "LoseWeight", Equipment = "WeightMachines", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 23, Goal = "LoseWeight", Equipment = "WeightMachines", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 24, Goal = "LoseWeight", Equipment = "WeightMachines", FitnessLevel = "Advanced" },

                new WorkoutGenerateRequest { Id = 25, Goal = "IncreaseEndurance", Equipment = "None", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 26, Goal = "IncreaseEndurance", Equipment = "None", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 27, Goal = "IncreaseEndurance", Equipment = "None", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 28, Goal = "IncreaseEndurance", Equipment = "TreadMill", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 29, Goal = "IncreaseEndurance", Equipment = "TreadMill", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 30, Goal = "IncreaseEndurance", Equipment = "TreadMill", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 31, Goal = "IncreaseEndurance", Equipment = "Bands", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 32, Goal = "IncreaseEndurance", Equipment = "Bands", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 33, Goal = "IncreaseEndurance", Equipment = "Bands", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 34, Goal = "IncreaseEndurance", Equipment = "WeightMachines", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 35, Goal = "IncreaseEndurance", Equipment = "WeightMachines", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 36, Goal = "IncreaseEndurance", Equipment = "WeightMachines", FitnessLevel = "Advanced" },

                new WorkoutGenerateRequest { Id = 37, Goal = "ImproveFlexibility", Equipment = "None", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 38, Goal = "ImproveFlexibility", Equipment = "None", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 39, Goal = "ImproveFlexibility", Equipment = "None", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 40, Goal = "ImproveFlexibility", Equipment = "TreadMill", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 41, Goal = "ImproveFlexibility", Equipment = "TreadMill", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 42, Goal = "ImproveFlexibility", Equipment = "TreadMill", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 43, Goal = "ImproveFlexibility", Equipment = "Bands", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 44, Goal = "ImproveFlexibility", Equipment = "Bands", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 45, Goal = "ImproveFlexibility", Equipment = "Bands", FitnessLevel = "Advanced" },
                new WorkoutGenerateRequest { Id = 46, Goal = "ImproveFlexibility", Equipment = "WeightMachines", FitnessLevel = "Beginner" },
                new WorkoutGenerateRequest { Id = 47, Goal = "ImproveFlexibility", Equipment = "WeightMachines", FitnessLevel = "Intermediate" },
                new WorkoutGenerateRequest { Id = 48, Goal = "ImproveFlexibility", Equipment = "WeightMachines", FitnessLevel = "Advanced" }
        );

            modelBuilder.Entity<WorkoutGenerateResponse>().HasData(
                new WorkoutGenerateResponse { Id = 1, ExerciseName = "Exercise",
                TargetMuscleGroup = "Muscle Group", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 1 },
                new WorkoutGenerateResponse { Id = 2, ExerciseName = "Exercise", TargetMuscleGroup = "Muscle Group", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 2 },
                new WorkoutGenerateResponse { Id = 3, ExerciseName = "Exercise", TargetMuscleGroup = "Muscle Group", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 3 },
                new WorkoutGenerateResponse { Id = 4, ExerciseName = "Treadmill Jogging", TargetMuscleGroup = "Cardio", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 4 },
                new WorkoutGenerateResponse { Id = 5, ExerciseName = "Advanced Treadmill Sprints", TargetMuscleGroup = "Cardio", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 5 },
                new WorkoutGenerateResponse { Id = 6, ExerciseName = "HIIT Circuit", TargetMuscleGroup = "Full Body", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 6 },
                new WorkoutGenerateResponse { Id = 7, ExerciseName = "Resistance Band Squats", TargetMuscleGroup = "Legs", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 7 },
                new WorkoutGenerateResponse { Id = 8, ExerciseName = "Resistance Band Deadlifts", TargetMuscleGroup = "Back", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 8 },
                new WorkoutGenerateResponse { Id = 9, ExerciseName = "Advanced Band Lunges", TargetMuscleGroup = "Legs", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 9 },
                new WorkoutGenerateResponse { Id = 10, ExerciseName = "Leg Press", TargetMuscleGroup = "Legs", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 10 },
                new WorkoutGenerateResponse { Id = 11, ExerciseName = "Chest Press Machine", TargetMuscleGroup = "Chest", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 11 },
                new WorkoutGenerateResponse { Id = 12, ExerciseName = "Pull-Down Machine", TargetMuscleGroup = "Back", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 12 },
                new WorkoutGenerateResponse { Id = 13, ExerciseName = "Bodyweight Circuit", TargetMuscleGroup = "Full Body", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 13 },
                new WorkoutGenerateResponse { Id = 14, ExerciseName = "Mountain Climbers", TargetMuscleGroup = "Core", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 14 },
                new WorkoutGenerateResponse { Id = 15, ExerciseName = "Burpees", TargetMuscleGroup = "Full Body", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 15 },
                new WorkoutGenerateResponse { Id = 16, ExerciseName = "Incline Walking", TargetMuscleGroup = "Cardio", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 16 },
                new WorkoutGenerateResponse { Id = 17, ExerciseName = "Treadmill Intervals", TargetMuscleGroup = "Cardio", ExerciseDuration = "25 minutes", WorkoutGenerateRequestId = 17 },
                new WorkoutGenerateResponse { Id = 18, ExerciseName = "Treadmill HIIT", TargetMuscleGroup = "Cardio", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 18 },
                new WorkoutGenerateResponse { Id = 19, ExerciseName = "Band High Knees", TargetMuscleGroup = "Cardio", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 19 },
                new WorkoutGenerateResponse { Id = 20, ExerciseName = "Band Side Steps", TargetMuscleGroup = "Legs", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 20 },
                new WorkoutGenerateResponse { Id = 21, ExerciseName = "Band Glute Kickbacks", TargetMuscleGroup = "Glutes", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 21 },
                new WorkoutGenerateResponse { Id = 22, ExerciseName = "Rowing Machine", TargetMuscleGroup = "Full Body", ExerciseDuration = "25 minutes", WorkoutGenerateRequestId = 22 },
                new WorkoutGenerateResponse { Id = 23, ExerciseName = "Elliptical Machine", TargetMuscleGroup = "Full Body", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 23 },
                new WorkoutGenerateResponse { Id = 24, ExerciseName = "Cycling Machine", TargetMuscleGroup = "Legs", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 24 },
                new WorkoutGenerateResponse { Id = 25, ExerciseName = "Jump Rope", TargetMuscleGroup = "Cardio", ExerciseDuration = "10 minutes", WorkoutGenerateRequestId = 25 },
                new WorkoutGenerateResponse { Id = 26, ExerciseName = "Stair Climbers", TargetMuscleGroup = "Cardio", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 26 },
                new WorkoutGenerateResponse { Id = 27, ExerciseName = "Advanced Jump Squats", TargetMuscleGroup = "Legs", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 27 },
                new WorkoutGenerateResponse { Id = 28, ExerciseName = "Treadmill Walk/Jog", TargetMuscleGroup = "Cardio", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 28 },
                new WorkoutGenerateResponse { Id = 29, ExerciseName = "Advanced Treadmill Jogging", TargetMuscleGroup = "Cardio", ExerciseDuration = "25 minutes", WorkoutGenerateRequestId = 29 },
                new WorkoutGenerateResponse { Id = 30, ExerciseName = "HIIT on Treadmill", TargetMuscleGroup = "Cardio", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 30 },
                new WorkoutGenerateResponse { Id = 31, ExerciseName = "Band-Assisted Pull-ups", TargetMuscleGroup = "Back", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 31 },
                new WorkoutGenerateResponse { Id = 32, ExerciseName = "Band Push-ups", TargetMuscleGroup = "Chest", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 32 },
                new WorkoutGenerateResponse { Id = 33, ExerciseName = "Band Rows", TargetMuscleGroup = "Back", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 33 },
                new WorkoutGenerateResponse { Id = 34, ExerciseName = "Weight Machines Warmup", TargetMuscleGroup = "Full Body", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 34 },
                new WorkoutGenerateResponse { Id = 35, ExerciseName = "Advanced Free Weights", TargetMuscleGroup = "Arms", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 35 },
                new WorkoutGenerateResponse { Id = 36, ExerciseName = "Weight Machine Rotations", TargetMuscleGroup = "Core", ExerciseDuration = "25 minutes", WorkoutGenerateRequestId = 36 },
                new WorkoutGenerateResponse { Id = 37, ExerciseName = "Dynamic Stretches", TargetMuscleGroup = "Full Body", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 37 },
                new WorkoutGenerateResponse { Id = 38, ExerciseName = "Yoga Beginner Flow", TargetMuscleGroup = "Flexibility", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 38 },
                new WorkoutGenerateResponse { Id = 39, ExerciseName = "Intermediate Yoga", TargetMuscleGroup = "Flexibility", ExerciseDuration = "35 minutes", WorkoutGenerateRequestId = 39 },
                new WorkoutGenerateResponse { Id = 40, ExerciseName = "Treadmill Stretches", TargetMuscleGroup = "Legs", ExerciseDuration = "10 minutes", WorkoutGenerateRequestId = 40 },
                new WorkoutGenerateResponse { Id = 41, ExerciseName = "Treadmill Cooldown", TargetMuscleGroup = "Full Body", ExerciseDuration = "10 minutes", WorkoutGenerateRequestId = 41 },
                new WorkoutGenerateResponse { Id = 42, ExerciseName = "Treadmill Side Steps", TargetMuscleGroup = "Legs", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 42 },
                new WorkoutGenerateResponse { Id = 43, ExerciseName = "Band Assisted Warm-ups", TargetMuscleGroup = "Legs", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 43 },
                new WorkoutGenerateResponse { Id = 44, ExerciseName = "Band Cooldown", TargetMuscleGroup = "Flexibility", ExerciseDuration = "15 minutes", WorkoutGenerateRequestId = 44 },
                new WorkoutGenerateResponse { Id = 45, ExerciseName = "Band Core Rotations", TargetMuscleGroup = "Core", ExerciseDuration = "10 minutes", WorkoutGenerateRequestId = 45 },
                new WorkoutGenerateResponse { Id = 46, ExerciseName = "Weight Machine Warmups", TargetMuscleGroup = "Full Body", ExerciseDuration = "20 minutes", WorkoutGenerateRequestId = 46 },
                new WorkoutGenerateResponse { Id = 47, ExerciseName = "Weight Machines Flexibility", TargetMuscleGroup = "Flexibility", ExerciseDuration = "25 minutes", WorkoutGenerateRequestId = 47 },
                new WorkoutGenerateResponse { Id = 48, ExerciseName = "Advanced Stretching", TargetMuscleGroup = "Full Body", ExerciseDuration = "30 minutes", WorkoutGenerateRequestId = 48 }
    );
            base.OnModelCreating(modelBuilder);
        }
    }
}