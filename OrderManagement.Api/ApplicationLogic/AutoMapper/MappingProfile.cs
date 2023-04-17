using AutoMapper;
using OrderManagement.Api.Models;
using OrderManagement.Core.Models;

public class MappingProfile : Profile {
    public MappingProfile() {

        // Mapping for BaseDTO
        CreateMap<BaseModel, BaseModelDTO>()
            .IncludeAllDerived()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UniqueId));

        // Add as many of these lines as you need to map your objects
        CreateMap<User, UserDTO>().ReverseMap();
        CreateMap<Account, AccountDTO>().ReverseMap();
    }
 }