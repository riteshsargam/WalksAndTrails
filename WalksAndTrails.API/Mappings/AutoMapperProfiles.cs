using AutoMapper;
using WalksAndTrails.API.Models.Domain;
using WalksAndTrails.API.Models.DTO;

namespace WalksAndTrails.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();   
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();    
        }
    }
}
