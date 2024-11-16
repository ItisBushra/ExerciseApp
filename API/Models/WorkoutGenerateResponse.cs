using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class WorkoutGenerateResponse
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDuration { get; set; }
        public string TargetMuscleGroup { get; set; }
        public int WorkoutGenerateRequestId { get; set; }
        [ForeignKey("WorkoutGenerateRequestId")]
        public WorkoutGenerateRequest WorkoutGenerateRequest { get; set; }
    }
}