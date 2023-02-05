using AutoMapper;
using CloudRMS.Models;
using CloudRMS.ViewModels;

namespace CloudRMS.DAO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
