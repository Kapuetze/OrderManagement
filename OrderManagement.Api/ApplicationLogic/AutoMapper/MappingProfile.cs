using AutoMapper;
using OrderManagement.Api.Models;
using OrderManagement.Core.Models;

public class MappingProfile : Profile {
    public MappingProfile() {

        // Mapping for BaseDTO
        CreateMap<IBaseModel, BaseModelDTO>()
            .IncludeAllDerived()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UniqueId));
        CreateMap<BaseModelDTO, IBaseModel>()
            .IncludeAllDerived()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.DateCreated, opt => opt.Ignore())
            .ForMember(dest => dest.DateModified, opt => opt.Ignore())
            .ForMember(dest => dest.UniqueId, opt => opt.Ignore());
        

        // Add as many of these lines as you need to map your objects
        CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        CreateMap<Account, AccountDTO>().ReverseMap();
        CreateMap<Contact, ContactDTO>().ReverseMap();
        CreateMap<Organisation, OrganisationDTO>().ReverseMap();
        CreateMap<Order, OrderDTO>().ReverseMap();
    }
 }