using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
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

        [HttpGet("Response")] 
        [ProducesResponseType(200, Type = typeof(ResponseDTO))]
        [AllowAnonymous]
        public async Task<IActionResult> GetResponseByRequest([FromQuery] string goal, 
                                                            [FromQuery] string equipment, 
                                                            [FromQuery] string fitnessLevel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var requestExists = await _workoutPlanRepository.RequestExistsAsync(goal, equipment, fitnessLevel);
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