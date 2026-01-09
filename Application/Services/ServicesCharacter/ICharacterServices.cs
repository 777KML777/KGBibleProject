using Application.Dtos;
using Application.Models;
using Domain.Entities.Character;
using Infra.Data; 

namespace Application.Services.ServicesCharacter;

public interface ICharacterServices : IService<CharacterInputModel, CharacterDto, CharacterEntity, CharacterEntityData>
{
    
}