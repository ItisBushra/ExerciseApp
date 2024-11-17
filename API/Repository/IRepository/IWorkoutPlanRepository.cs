using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository.IRepository
{
    public interface IWorkoutPlanRepository
    {
        Task<ICollection<WorkoutGenerateResponse>> GetAllResponses();
        Task<ICollection<WorkoutGenerateRequest>> GetAllRequests();
        Task <WorkoutGenerateResponse> GetResponseByRequestAsync(WorkoutGenerateRequest request);
        Task<bool> Save();
        Task <bool> ResponsesExistsAsync(int id);
        Task <WorkoutGenerateRequest> RequestExistsAsync(string goal, string equipment, string fitnessLevel);
    }
}