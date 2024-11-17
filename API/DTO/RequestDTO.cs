using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class RequestDTO
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public string Equipment { get; set; }
        public string FitnessLevel { get; set; }
    }
}