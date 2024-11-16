using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class WorkoutGenerateRequest
    {
        public int Id { get; set; }
        [Range(18, 50)]
        public ICollection<string> Age { get; set; } = new List<string> { "18-25", "26-35", "36-45", "46-50" };
        public Gender Gender { get; set; }
        public ICollection<string> Height { get; set; } = new List<string> { "150-160 cm", "160-170 cm", "170-180 cm", "180-190 cm" };
        public ICollection<string> Weight { get; set; } = new List<string> { "50-60 kg", "60-70 kg", "70-80 kg", "80-90 kg" };
        public Goal Goal { get; set; }
        public Equipment Equipment { get; set; }
        [Range(1, 7)]
        public int DaysPerWeek { get; set; }
        public FitnessLevel FitnessLevel { get; set; }
        public WorkoutGenerateResponse WorkoutGenerateResponse { get; set; }
        //public int WorkoutGenerateResponseId { get; set; }
        //[ForeignKey("WorkoutGenerateResponseId")]
        //public WorkoutGenerateResponse WorkoutGenerateResponse { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum FitnessLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
    public enum Goal
    {
        BuildMuscles,
        LoseWeight,
        IncreaseEndurance,
        ImproveFlexibility        
    }

    public enum Equipment
    {
        None,
        Barbells,
        TreadMill,
        Dumbbells,
        Bands,
        WeightMachines
    }

}