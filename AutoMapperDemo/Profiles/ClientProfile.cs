using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientViewModel>()
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email));
        }
    }
}
