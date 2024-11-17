using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class WorkoutPlanRepository : IWorkoutPlanRepository
    {
        private readonly DBContext _db;
        public WorkoutPlanRepository(DBContext db)
        {
            _db = db;
        }
        public async Task<bool> ResponsesExistsAsync(int id)
        {
            return await _db.WorkoutGenerateResponses.AnyAsync(b=>b.Id == id);
        }
        public async Task<WorkoutGenerateRequest> RequestExistsAsync(string goal, string equipment, string fitnessLevel)
        {
                return await _db.WorkoutGenerateRequests
                .FirstOrDefaultAsync(r => r.Goal == goal &&
                r.Equipment == equipment && r.FitnessLevel == fitnessLevel); 
        }
        public async Task<ICollection<WorkoutGenerateResponse>> GetAllResponses()
        {
            return await _db.WorkoutGenerateResponses.Include(r => r.WorkoutGenerateRequest).ToListAsync();
        }
        public async Task<ICollection<WorkoutGenerateRequest>> GetAllRequests()
        {
            return await _db.WorkoutGenerateRequests
                .ToListAsync();
        }
        public async Task<WorkoutGenerateResponse> GetResponseByRequestAsync(WorkoutGenerateRequest request)
        {
            return await _db.WorkoutGenerateResponses
            .FirstOrDefaultAsync(r => r.WorkoutGenerateRequestId == request.Id);
        }

        public async Task<bool> Save()
        {
            var saved = await  _db.SaveChangesAsync();
            return saved > 0 ? true: false;
        }
    }
}