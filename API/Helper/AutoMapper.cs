using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using API.Models;
using AutoMapper;

namespace API.Helper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<WorkoutGenerateRequest, RequestDTO>().ReverseMap();
            CreateMap<WorkoutGenerateResponse, ResponseDTO>().ForMember(dest => dest.WorkoutGenerateRequestId, opt => opt.MapFrom(src => src.WorkoutGenerateRequestId)).ReverseMap(); 
        }
    }
}