using AutoMapper;
using Traveltech.Models;
using Traveltech.Models.Widgets;

namespace Traveltech.Controllers.Dto.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<Footer, FooterDto>().ReverseMap();
            CreateMap<MenuItem, MenuItemDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<TimeFormat, TimeFormatDto>().ReverseMap();
            CreateMap<Header, HeaderDto>().ReverseMap();
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
