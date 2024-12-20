using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helper
{
    public class Options
    {
        public static readonly Dictionary<string, string> GoalMappings = new()
        {
            { "Build Muscle", "BuildMuscles" },
            { "Improve Flexibility", "ImproveFlexibility" },
            { "Lose Weight", "LoseWeight" },
            { "Increase Endurance", "IncreaseEndurance" }
        };

        public static readonly Dictionary<string, string> EquipmentMappings = new()
        {
            { "None", "None" },
            { "Treadmill", "TreadMill" },
            { "Bands", "Bands" },
            { "Weight Machines", "WeightMachines" }
        };

        public static readonly Dictionary<string, string> FitnessLevelMappings = new()
        {
            { "Beginner", "Beginner" },
            { "Intermediate", "Intermediate" },
            { "Advanced", "Advanced" },
        };

        public static readonly Dictionary<string, string> GenderMappings = new()
        {
            { "Male", "male" },
            { "Female", "female" },
        };

        public static readonly Dictionary<string, string> ActivityLevelMappings = new()
        {
            { "Inactive", "Inactive" },
            { "Low Active", "Low Active" },
            { "Active", "Active" },
            { "Very Active", "Very Active" },
        };
    }
}