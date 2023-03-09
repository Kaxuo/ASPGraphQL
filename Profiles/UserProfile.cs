using API.ConsumerModels;
using API.Models;
using AutoMapper;
namespace API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ConsumerUser>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Mails, opt => opt.MapFrom(src => src.Mails));
        }
    }
}