using Domain.Exceptions;
using Domain.Extension;

namespace Domain.Services;

public class BookService
(
    IBookRepository _repository, 
    ICharacterRepository _characterRepository
) : IBookService
{
    public BookDto Create(BookDto input)
    {

        BookEntity entity = _repository.GetByName(input.Nome);

        if (entity != null)
            throw new BookDomainExceptionAlreadyExist(input.Nome);

        return _repository.Create(input.ToEntity()).ToDto(); ;
    }


    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    // public BookDto GetById(int id, bool include = false)
    // {
    //     BookEntityData bookEntityData = _repository.GetById<BookEntityData>(id);
    //     BookEntity bookEntity = MappingEntityDataToEntity(bookEntityData);

    //     //Buscando objeto pessoa do banco
    //     CharacterServices characterServices = new CharacterServices();

    //     CharacterEntityData characterEntityData = _repository.GetById<CharacterEntityData>(bookEntity.AutorId);
    //     CharacterEntity characterEntity = characterServices.MappingEntityDataToEntity(characterEntityData);
    //     CharacterDto characterDto = characterServices.MappingEntityToDto(characterEntity);

    //     //Buscando objetos concatenados do banco
    //     BookDto bookDto = new BookDto(bookEntity.Nome, bookEntity.Testamento, bookEntity.AutorId, bookEntity.Descricao, characterDto.Nome,
    //                         bookEntity.Capitulos, bookEntity.Versiculos);

    //     return bookDto;

    // }

    public BookDto GetById(int id)
    {
        BookDto bookDto = _repository.GetById(id).ToDto();

        CharacterDto characterDto = _characterRepository.GetById(bookDto.AutorId).ToDto();
        

        return bookDto;
    }

    // public List<BookEntity> MappingListEntityDataToListEntity(List<BookEntityData> obj)
    // {
    //     List<BookEntity> bookEntities = new List<BookEntity>();
    //     obj.ForEach(item => bookEntities.Add(new BookEntity(item.Nome, item.Testamento, item.AutorId, item.Descricao, item.Capitulos, item.Versiculos)));

    //     return bookEntities;
    // }

    public IEnumerable<BookDto> Read()
    {
        // TODO: Ter a quantidade de autores que escreveram o livro. 
        return [.. _repository.Read().ToDtoEnumerable()];
    }


    //     var characterEntity = characterServices.MappingListEntityDataToListEntity(characterData);

    //     var characterDto = characterServices.MappingListEntityToListDto(characterEntity);

    //     List<BookDto> bookDto = new List<BookDto>();

    //     //Retornar objetos do banco
    //     bookEntitiy?.ForEach(item =>
    //         bookDto.Add(
    //             new BookDto(item.Nome,
    //              item.Testamento,
    //              item.AutorId,
    //              item.Descricao,
    //              characterEntity.FirstOrDefault(x => x.Id == item.AutorId)?.Nome,
    //              item.Capitulos,
    //              item.Versiculos)));

    //     return bookDto;

    // }



    // public bool Update(int id, BookInputModel obj, bool include = false)
    // {
    //     var book = GetById(id);

    //     if (book == null)
    //     {
    //         throw new Exception("Nenhum produto encontrado");
    //     }
    //     BookEntity bookEntity = MappingInputModelToEntity(obj);
    //     BookEntityData bookEntityData = MappingEntityToEntityData(bookEntity);
    //     bookEntityData.Id = id;

    //     _repository.Update<BookEntityData>(bookEntityData);

    //     return true;
    // }

    public BookDto Update(BookDto dto)
    {
        throw new NotImplementedException();
    }
}