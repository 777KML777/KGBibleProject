using Application.Inputs;
using Domain.Dtos;

namespace Application.Interfaces;

public interface ICharacterAppService
{
    public CharacterDto Create(CharacterInputModel input);
    public List<CharacterDto> Read();
}