using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;

namespace API.Services
{
    public class Seed
    {
        public static async Task SeedWorkoutRequests(DBContext context)
        {
            if (!context.WorkoutGenerateRequests.Any())  // Only seed if the database is empty
            {
                // Defining the possible values for each property
                var ageRanges = new List<string> { "18-25", "26-35", "36-45", "46-50" };
                var heightRanges = new List<string> { "150-160 cm", "160-170 cm", "170-180 cm", "180-190 cm" };
                var weightRanges = new List<string> { "50-60 kg", "60-70 kg", "70-80 kg", "80-90 kg" };
                var goals = new List<Goal> { Goal.BuildMuscles, Goal.LoseWeight, Goal.IncreaseEndurance, Goal.ImproveFlexibility };
                var equipmentOptions = new List<Equipment> { Equipment.None, Equipment.Barbells, Equipment.TreadMill, Equipment.Dumbbells, Equipment.Bands, Equipment.WeightMachines };
                var fitnessLevels = new List<FitnessLevel> { FitnessLevel.Beginner, FitnessLevel.Intermediate, FitnessLevel.Advanced };
                var genders = new List<Gender> { Gender.Male, Gender.Female };
                var daysPerWeek = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

                var workoutRequests = new List<WorkoutGenerateRequest>();
                int idCounter = 1;

                // Looping through all possible values for each property to generate different combinations
                foreach (var age in ageRanges)
                {
                    foreach (var gender in genders)
                    {
                        foreach (var height in heightRanges)
                        {
                            foreach (var weight in weightRanges)
                            {
                                foreach (var goal in goals)
                                {
                                    foreach (var equipment in equipmentOptions)
                                    {
                                        foreach (var fitnessLevel in fitnessLevels)
                                        {
                                            foreach (var days in daysPerWeek)
                                            {
                                                // Creating a new WorkoutGenerateRequest for each combination
                                                var request = new WorkoutGenerateRequest
                                                {
                                                    Id = idCounter++, // Auto-incrementing Id
                                                        
                                                    // Assigning properties explicitly from the lists
                                                    Age = new List<string> { age }, // Age range selection
                                                    Gender = gender, // Gender selection
                                                    Height = new List<string> { height }, // Height range selection
                                                    Weight = new List<string> { weight }, // Weight range selection
                                                    Goal = goal, // Goal selection (e.g., BuildMuscles)
                                                    Equipment = equipment, // Equipment selection (e.g., Dumbbells)
                                                    DaysPerWeek = days, // Number of days per week (1-7)
                                                    FitnessLevel = fitnessLevel // Fitness level (Beginner, Intermediate, etc.)
                                                };
                                                // Adding the created request to the list
                                                workoutRequests.Add(request);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                // Saving all the generated requests into the database
                await context.WorkoutGenerateRequests.AddRangeAsync(workoutRequests);
                await context.SaveChangesAsync();
            }
        }
    }
}