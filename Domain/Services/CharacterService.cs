
using Domain.Exceptions;
using Domain.Extension;

namespace Domain.Services;

public class CharacterService
(
    ICharacterRepository _repository
) : ICharacterService
{
    public CharacterDto Create(CharacterDto input)
    {
        throw new NotImplementedException();
    }


    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    // public CharacterDto GetById(int id, bool include = false)
    // {
    //     CharacterEntityData bookEntityData = _repository.GetById<CharacterEntityData>(id);
    //     CharacterEntity bookEntity = MappingEntityDataToEntity(bookEntityData);

    //     //Buscando objeto pessoa do banco
    //     CharacterServices characterServices = new CharacterServices();

    //     CharacterEntityData characterEntityData = _repository.GetById<CharacterEntityData>(bookEntity.AutorId);
    //     CharacterEntity characterEntity = characterServices.MappingEntityDataToEntity(characterEntityData);
    //     CharacterDto characterDto = characterServices.MappingEntityToDto(characterEntity);

    //     //Buscando objetos concatenados do banco
    //     CharacterDto characterDto = new CharacterDto(bookEntity.Nome, bookEntity.Testamento, bookEntity.AutorId, bookEntity.Descricao, characterDto.Nome,
    //                         bookEntity.Capitulos, bookEntity.Versiculos);

    //     return characterDto;

    // }

    public CharacterDto GetById(int id)
    {
        throw new NotImplementedException();
    }

    // public List<CharacterEntity> MappingListEntityDataToListEntity(List<CharacterEntityData> obj)
    // {
    //     List<CharacterEntity> bookEntities = new List<CharacterEntity>();
    //     obj.ForEach(item => bookEntities.Add(new CharacterEntity(item.Nome, item.Testamento, item.AutorId, item.Descricao, item.Capitulos, item.Versiculos)));

    //     return bookEntities;
    // }

    public IEnumerable<CharacterDto> Read()
    {
        // TODO: Ter a quantidade de autores que escreveram o livro. 
        throw new NotImplementedException();
    }


    //     var characterEntity = characterServices.MappingListEntityDataToListEntity(characterData);

    //     var characterDto = characterServices.MappingListEntityToListDto(characterEntity);

    //     List<CharacterDto> characterDto = new List<CharacterDto>();

    //     //Retornar objetos do banco
    //     bookEntitiy?.ForEach(item =>
    //         characterDto.Add(
    //             new CharacterDto(item.Nome,
    //              item.Testamento,
    //              item.AutorId,
    //              item.Descricao,
    //              characterEntity.FirstOrDefault(x => x.Id == item.AutorId)?.Nome,
    //              item.Capitulos,
    //              item.Versiculos)));

    //     return characterDto;

    // }



    // public bool Update(int id, CharacterInputModel obj, bool include = false)
    // {
    //     var book = GetById(id);

    //     if (book == null)
    //     {
    //         throw new Exception("Nenhum produto encontrado");
    //     }
    //     CharacterEntity bookEntity = MappingInputModelToEntity(obj);
    //     CharacterEntityData bookEntityData = MappingEntityToEntityData(bookEntity);
    //     bookEntityData.Id = id;

    //     _repository.Update<CharacterEntityData>(bookEntityData);

    //     return true;
    // }

    public CharacterDto Update(CharacterDto dto)
    {
        throw new NotImplementedException();
    }
}