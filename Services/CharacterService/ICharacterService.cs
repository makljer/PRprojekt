using System.Threading.Tasks;
using webapi.Controllers.Models;
using System.Collections.Generic;
using webapi.Dtos.Character;

namespace webapi.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}