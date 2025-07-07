using AutoMapper;
using DiligenciaProveedores.Application.DTOs;
using DiligenciaProveedores.Domain.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Provider, ProviderDto>()
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.ToString()));

        CreateMap<CreateProviderDto, Provider>();
        CreateMap<UpdateProviderDto, Provider>()
            .ForMember(dest => dest.Id, opt => opt.Ignore()); // para evitar sobrescribir Id
    }
}