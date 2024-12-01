using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using API.Models;
using API.Helper;
using API.DTO;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthAdviceController : Controller
    {
        private readonly HttpClient _httpClient;
        public HealthAdviceController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet("options")]
        [ProducesResponseType(200, Type = typeof(Options))]
        [AllowAnonymous]
        public IActionResult GetOptions()
        {
            // Return all valid options for clients to display as selections
            var options = new
            {
                Sex = Options.GenderMappings.Keys,
                ActivityLevel = Options.FitnessLevelMappings.Keys,
            };

            return Ok(options);
        }
        [HttpPost("HealthAdvice")]
        [ProducesResponseType(200, Type = typeof(AdviceResponseDTO))]
        [AllowAnonymous]
        public async Task<IActionResult> Advice([FromQuery] string sex, 
                                                [FromQuery] int age, 
                                                [FromQuery] string activity_Level,
                                                [FromQuery] int Weight,
                                                [FromQuery] int Height)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var ValidActivityLevel = Options.ActivityLevelMappings.Keys.ToList();
            var ValidGender = Options.GenderMappings.Keys.ToList();

            if(string.IsNullOrWhiteSpace(activity_Level) && string.IsNullOrWhiteSpace(sex) && 
               age.Equals(null) && Weight.Equals(null) && Height.Equals(null))
            {
                return Ok(new
                {
                    Message = "Please select from the following options.",
                    Options = new
                    {
                        ActivityLevels = ValidActivityLevel,
                        Genders = ValidGender,
                    }
                });
            }
            var gender = Options.GenderMappings[sex];
            var Age = age;
            var weight = Weight;
            var height = Height;
            var activityLevel = Options.ActivityLevelMappings[activity_Level];
            var request = new HttpRequestMessage //measurement_units=met age_type
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://nutrition-calculator.p.rapidapi.com/api/nutrition-info?measurement_units=met&sex={gender}&age_value={Age}&age_type=yrs&cm={height}&kilos={weight}&activity_level={activityLevel}"),
                Headers =
                {
                    { "x-rapidapi-key", "99b96f10bdmsh3217cdc091f6f64p1b2bf8jsn04ddda4a28de" },
                    { "x-rapidapi-host", "nutrition-calculator.p.rapidapi.com" },
                },
            };
            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var responsedto = JsonConvert.DeserializeObject<AdviceResponseDTO>(body); //null
                return Ok(responsedto);
            }
        }
    }
}