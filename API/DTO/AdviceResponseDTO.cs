using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTO
{
    public class AdviceResponseDTO
    {
        public BMIEER BMI_EER { get; set; }
        public MacronutrientsTable macronutrients_table { get; set; }
             
    }
    public class BMIEER
    {
        public string BMI { get; set; }
        [JsonProperty("Estimated Daily Caloric Needs")]
        public string EstimatedDailyCaloricNeeds { get; set; }
    }

    public class MacronutrientsTable
    {
        [JsonProperty("macronutrients-table")]
        public List<List<string>> macronutrientstable { get; set; }
    }

}