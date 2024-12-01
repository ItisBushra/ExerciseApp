using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.DTO
{
    public class ResponseDTO
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDuration { get; set; }
        public string TargetMuscleGroup { get; set; }
        public int WorkoutGenerateRequestId { get; set; }
    }
}