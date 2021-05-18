using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveltech.Models;
using Traveltech.Models.Widgets;

namespace Traveltech.Controllers.Dto.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<DateFormat, DateFormatDto>().ReverseMap();
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<WebSite, WebSiteDto>().ReverseMap();
            CreateMap<SocialMedia, SocialMediaDto>().ReverseMap();
            CreateMap<Sumbol, SumbolDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Land, LandDto>().ReverseMap();
            CreateMap<State, StateDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<HomePage, HomePageDto>().ReverseMap();
            CreateMap<Section, SectionDto>().ReverseMap();
            CreateMap<Page, PageDto>().ReverseMap();
        }
    }
}
