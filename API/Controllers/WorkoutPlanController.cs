using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using API.Helper;
using API.Models;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutPlanController : Controller
    {
        private readonly IWorkoutPlanRepository _workoutPlanRepository;
        private readonly IMapper _map;
        public WorkoutPlanController(IWorkoutPlanRepository workoutPlanRepository, IMapper map)
        {
            _workoutPlanRepository = workoutPlanRepository;
            _map = map;            
        }

        [HttpGet("AllRequests")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<RequestDTO>))]
        [AllowAnonymous]
        public async Task<IActionResult> Requests()
        {
            var requests = _map.Map<List<RequestDTO>>
            (await _workoutPlanRepository.GetAllRequests());
                        if(!ModelState.IsValid) return BadRequest();
            return Ok(requests);
        }
     
        [HttpGet("AllResponses")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ResponseDTO>))]
        [AllowAnonymous]
        public async Task<IActionResult> Responses()
        {
            var responses = _map.Map<List<ResponseDTO>>
            (await _workoutPlanRepository.GetAllResponses());
                        if(!ModelState.IsValid) return BadRequest();
            return Ok(responses);
        }

        [HttpGet("options")]
        [ProducesResponseType(200, Type = typeof(Options))]
        [AllowAnonymous]
        public IActionResult GetOptions()
        {
            // Return all valid options for clients to display as selections
            var options = new
            {
                Goals = Options.GoalMappings.Keys,
                Equipment = Options.EquipmentMappings.Keys,
                FitnessLevels = Options.FitnessLevelMappings.Keys
            };

            return Ok(options);
        }

        [HttpGet("Response")] 
        [ProducesResponseType(200, Type = typeof(ResponseDTO))]
        [AllowAnonymous]
        public async Task<IActionResult> GetResponseByRequest([FromQuery] string goal, 
                                                            [FromQuery] string equipment, 
                                                            [FromQuery] string fitnessLevel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

                var validGoals = Options.GoalMappings.Keys.ToList();
                var validEquipment = Options.EquipmentMappings.Keys.ToList();
                var validFitnessLevels = Options.FitnessLevelMappings.Keys.ToList();

                // If no query parameters are provided, return available options
                if (string.IsNullOrWhiteSpace(goal) && 
                    string.IsNullOrWhiteSpace(equipment) && 
                    string.IsNullOrWhiteSpace(fitnessLevel))
                {
                    return Ok(new
                    {
                        Message = "Please select from the following options.",
                        Options = new
                        {
                            Goals = validGoals,
                            Equipment = validEquipment,
                            FitnessLevels = validFitnessLevels
                        }
                    });
                }
            
            var dbGoal = Options.GoalMappings[goal];
            var dbEquipment = Options.EquipmentMappings[equipment];
            var dbFitnessLevel = Options.FitnessLevelMappings[fitnessLevel];

            var requestExists = await _workoutPlanRepository.RequestExistsAsync(dbGoal, dbEquipment, dbFitnessLevel);
            if (requestExists == null) return NotFound("Request does not exist.");

            var response = await _workoutPlanRepository.GetResponseByRequestAsync(requestExists);
            if (response == null)
                return NotFound("No response found for the provided request.");

            // Map the response object to a ResponseDTO
            var resDTO = _map.Map<ResponseDTO>(response);

            return Ok(resDTO);
        }
    }
}