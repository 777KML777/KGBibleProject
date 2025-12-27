
using Domain.Exceptions;
using Domain.Extension;

namespace Domain.Services;

public class BookService
(
    IBookRepository _repository
) : IBookService
{
    public BookDto Create(BookDto input)
    {

        BookEntity entity = _repository.GetByName(input.Nome);

        if (entity != null)
            throw new BookDomainExceptionAlreadyExist(input.Nome);

        return   _repository.Create(input.ToEntity()).ToDto();;
    }


    public bool Delete(int identifier)
    {
        throw new NotImplementedException();
    }

    // public BookDto GetById(int id, bool include = false)
    // {
    //     BookEntityData bookEntityData = _repository.GetById<BookEntityData>(id);
    //     BookEntity bookEntity = MappingEntityDataToEntity(bookEntityData);

    //     //Buscando objeto pessoa do banco
    //     PersonServices personServices = new PersonServices();

    //     PersonEntityData personEntityData = _repository.GetById<PersonEntityData>(bookEntity.AutorId);
    //     PersonEntity personEntity = personServices.MappingEntityDataToEntity(personEntityData);
    //     PersonDto personDto = personServices.MappingEntityToDto(personEntity);

    //     //Buscando objetos concatenados do banco
    //     BookDto bookDto = new BookDto(bookEntity.Nome, bookEntity.Testamento, bookEntity.AutorId, bookEntity.Descricao, personDto.Nome,
    //                         bookEntity.Capitulos, bookEntity.Versiculos);

    //     return bookDto;

    // }

    public BookDto GetById(int identifier)
    {
        throw new NotImplementedException();
    }


    // public List<BookEntity> MappingListEntityDataToListEntity(List<BookEntityData> obj)
    // {
    //     List<BookEntity> bookEntities = new List<BookEntity>();
    //     obj.ForEach(item => bookEntities.Add(new BookEntity(item.Nome, item.Testamento, item.AutorId, item.Descricao, item.Capitulos, item.Versiculos)));

    //     return bookEntities;
    // }


    // public List<BookDto> Read(bool include = false)
    // {
    //     var book = _repository.ReadAll<BookEntityData>().ToList();
    //     List<BookEntity> bookEntitiy = MappingListEntityDataToListEntity(book);


    //     //Chamando lista e mapeando objetos de PERSON
    //     PersonServices personServices = new PersonServices();
    //     var personData = _repository.ReadAll<PersonEntityData>().ToList();

    //     var personEntity = personServices.MappingListEntityDataToListEntity(personData);

    //     var personDto = personServices.MappingListEntityToListDto(personEntity);

    //     List<BookDto> bookDto = new List<BookDto>();

    //     //Retornar objetos do banco
    //     bookEntitiy?.ForEach(item =>
    //         bookDto.Add(
    //             new BookDto(item.Nome,
    //              item.Testamento,
    //              item.AutorId,
    //              item.Descricao,
    //              personEntity.FirstOrDefault(x => x.Id == item.AutorId)?.Nome,
    //              item.Capitulos,
    //              item.Versiculos)));

    //     return bookDto;

    // }

    public IEnumerable<BookDto> Read()
    {
        throw new NotImplementedException();
    }

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