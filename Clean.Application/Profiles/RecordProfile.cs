using AutoMapper;
using Clean.Application.DTOs.RecordArea;
using Clean.Domain.Entities.RecordArea;

namespace Clean.Application.Profiles;

public class RecordProfile : Profile
{
    public RecordProfile()
    {
        CreateMap<Record, RecordDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ReverseMap();

        CreateMap<CreateRecordRequestDto, Record>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ReverseMap();
    }
}
