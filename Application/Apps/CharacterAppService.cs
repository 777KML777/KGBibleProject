using Domain.Dtos;
using Domain.Interfaces;
using Application.Inputs;

namespace Application.Apps;

public class CharacterAppService
(
    ICharacterService _service
) : ICharacterAppService
{
    public CharacterDto Create(CharacterInputModel input)
    {   
        return _service.Create
        (
            input.Character
        );
    }

    public List<CharacterDto> Read()
    {
        return [.. _service.Read()];
    }
}