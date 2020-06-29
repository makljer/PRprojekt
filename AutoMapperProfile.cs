using AutoMapper;
using webapi.Controllers.Models;
using webapi.Dtos.Character;

namespace webapi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}