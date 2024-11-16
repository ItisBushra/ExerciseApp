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
        public ICollection<Day> Days { get; set; } = new List<Day>();
        public int WorkoutGenerateRequestId { get; set; }
        [ForeignKey("WorkoutGenerateRequestId")]
        public WorkoutGenerateRequest WorkoutGenerateRequest { get; set; }
    }

    public class Day
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDuration { get; set; }
        public string ExerciseSets { get; set; }
        public string ExerciseReps { get; set; }
        public string Equipment { get; set; }

        public int WorkoutGenerateResponseId { get; set; }
        [ForeignKey("WorkoutGenerateResponseId")]
        public WorkoutGenerateResponse WorkoutGenerateResponse { get; set; }

    }
}