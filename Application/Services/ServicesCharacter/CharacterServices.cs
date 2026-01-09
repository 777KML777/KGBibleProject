using Application.Dtos;
using Application.Models;
using Domain.Entities.Character;
using Infra.Data;
using Infra.Data.CharacterRepository;

namespace Application.Services.ServicesCharacter;

public class CharacterServices : ICharacterServices
{
    private readonly ICharacterRepository _repository;
    public CharacterServices()
    {
        _repository = new CharacterRepository();
    }
    public bool Create(CharacterInputModel obj, bool include = false)
    {
        CharacterEntity characterEntity = MappingInputModelToEntity(obj);
        CharacterEntityData characterEntityData = MappingEntityToEntityData(characterEntity);

        _repository.Create(characterEntityData);
        return true;
    }

    public bool Delete(CharacterInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public CharacterDto GetById(int id, bool include = false)
    {
        var pessoa = _repository.GetById<CharacterEntityData>(id);
        CharacterEntity characterEntity = MappingEntityDataToEntity(pessoa);
        CharacterDto characterDto = MappingEntityToDto(characterEntity);

        return characterDto;
    }

    public CharacterEntity MappingEntityDataToEntity(CharacterEntityData obj)
    {
        CharacterEntity characterEntity = new CharacterEntity(obj.Nome, obj.Descricao, obj.Sexo);
        return characterEntity;
    }

    public CharacterDto MappingEntityToDto(CharacterEntity obj)
    {
        CharacterDto characterDto = new CharacterDto(obj.Nome, obj.Descricao, obj.Sexo);
        return characterDto;
    }

    public CharacterEntityData MappingEntityToEntityData(CharacterEntity obj)
    {
        CharacterEntityData characterEntityData = new CharacterEntityData();

        characterEntityData.Nome = obj.Nome;
        characterEntityData.Descricao = obj.Descricao;
        characterEntityData.Sexo = obj.Sexo;

        return characterEntityData;
    }

    public CharacterEntity MappingInputModelToEntity(CharacterInputModel obj)
    {
        CharacterEntity characterEntity = new CharacterEntity(obj.Nome, obj.Descricao, obj.Sexo);
        return characterEntity;
    }

    public List<CharacterEntity> MappingListEntityDataToListEntity(List<CharacterEntityData> obj)
    {
        List<CharacterEntity> characters = new List<CharacterEntity>();
        obj.ForEach(item =>
        {
            var character = new CharacterEntity(item.Nome, item.Descricao, item.Sexo)
            {
                Id = item.Id   // agora o Id vai junto!
            };
            characters.Add(character);
        });
        return characters;
    }

    public List<CharacterDto> MappingListEntityToListDto(List<CharacterEntity> obj)
    {
        List<CharacterDto> characters = new List<CharacterDto>();
        obj.ForEach(item => characters.Add(new CharacterDto(item.Nome, item.Descricao, item.Sexo)));
        return characters;
    }

    public List<CharacterEntityData> MappingListEntityToListEntityData(List<CharacterEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<CharacterDto> Read(bool include = false)
    {
        // _repository.ReadAll<CharacterEntityData>();
        //    var y = MappingListEntityToListDto(new List<CharacterEntity>());
        var y = MappingListEntityToListDto
        (
            MappingListEntityDataToListEntity
            (
                 _repository.ReadAll<CharacterEntityData>().ToList()
            )
        );
        return y;
    }

    public bool Update(int id, CharacterInputModel obj, bool include = false)
    {
        CharacterEntity characterEntity = MappingInputModelToEntity(obj);
        CharacterEntityData characterEntityData = MappingEntityToEntityData(characterEntity);

        characterEntityData.Id = id;

        _repository.Update<CharacterEntityData>(characterEntityData);

        return true;
    }
}