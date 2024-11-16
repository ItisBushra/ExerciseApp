using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {
            
        }
        public DbSet<WorkoutGenerateRequest> WorkoutGenerateRequests { get;}
        public DbSet<WorkoutGenerateResponse> WorkoutGenerateResponses { get;}
        public DbSet<Day> Days { get;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to one
            modelBuilder.Entity<WorkoutGenerateRequest>()
                .HasOne(b => b.WorkoutGenerateResponse)
                .WithOne(rt => rt.WorkoutGenerateRequest)
                .HasForeignKey<WorkoutGenerateResponse>(rt => rt.WorkoutGenerateRequestId);
            
            //One-to-Many
            modelBuilder.Entity<WorkoutGenerateResponse>()
                .HasMany(s => s.Days)
                .WithOne(b => b.WorkoutGenerateResponse)
                .HasForeignKey(b => b.WorkoutGenerateResponseId);

            base.OnModelCreating(modelBuilder);
        }
    }
}