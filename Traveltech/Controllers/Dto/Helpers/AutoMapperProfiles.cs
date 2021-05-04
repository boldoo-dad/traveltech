using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveltech.Models;

namespace Traveltech.Controllers.Dto.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Page, PageDto>().ReverseMap();
            CreateMap<Section, SectionDto>().ReverseMap();
        }
    }
}
