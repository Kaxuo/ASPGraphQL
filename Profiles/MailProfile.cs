using API.ConsumerModels;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class MailProfile : Profile
    {
        public MailProfile()
        {
            CreateMap<Mail, ConsumerMail>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
            .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
        }
    }
}