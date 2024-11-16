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
        public string Goal { get; set; }
        public string Equipment { get; set; }
        public string FitnessLevel { get; set; }
        public WorkoutGenerateResponse? WorkoutGenerateResponse { get; set; }
    }
}