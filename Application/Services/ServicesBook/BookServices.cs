using Application.Dtos;
using Application.Models;
using Application.Services.ServicesPerson;
using Domain.Entities.Book;
using Domain.Entities.Person;
using JsonFile.Repository;
using JsonFile.Repository.BookRepository;

namespace Application.Services.ServicesBook;

public class BookServices : IBookServices
{
    private readonly IBookRepository _repository;
    public BookServices()
    {
        _repository = new BookRepository();
    }
    public bool Create(BookInputModel obj, bool include = false)
    {
        BookEntity bookEntity = MappingInputModelToEntity(obj);
        BookEntityData bookEntityData = MappingEntityToEntityData(bookEntity);

        _repository.Create<BookEntityData>(bookEntityData);
        
        return true;
    }

    public bool Delete(BookInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public BookDto GetById(int id, bool include = false)
    {   
        BookEntityData bookEntityData = _repository.GetById<BookEntityData>(id);
        BookEntity bookEntity = MappingEntityDataToEntity(bookEntityData);

        //Buscando objeto pessoa do banco
        PersonServices personServices = new PersonServices();

        PersonEntityData personEntityData = _repository.GetById<PersonEntityData>(bookEntity.AutorId);
        PersonEntity personEntity = personServices.MappingEntityDataToEntity(personEntityData);
        PersonDto personDto = personServices.MappingEntityToDto(personEntity);

        //Buscando objetos concatenados do banco
        BookDto bookDto = new BookDto(bookEntity.Nome, bookEntity.Testamento,bookEntity.AutorId, bookEntity.Descricao, personDto.Nome, 
                            bookEntity.Capitulos, bookEntity.Versiculos);

        return bookDto;
        
    }

    public BookEntity MappingEntityDataToEntity(BookEntityData obj)
    {
        BookEntity bookEntity = new BookEntity(obj.Nome, obj.Testamento, obj.AutorId, obj.Descricao, obj.Capitulos, obj.Versiculos);
        return bookEntity;
    }

    public BookDto MappingEntityToDto(BookEntity obj)
    {   
        throw new NotImplementedException();
    }

    public BookEntityData MappingEntityToEntityData(BookEntity obj)
    {
        BookEntityData bookEntityData = new BookEntityData();

        bookEntityData.AutorId = obj.AutorId;
        bookEntityData.Descricao = obj.Descricao;
        bookEntityData.Id = obj.Id;
        bookEntityData.Nome = obj.Nome;
        bookEntityData.Testamento = obj.Testamento;
        bookEntityData.Capitulos = obj.Capitulos;
        bookEntityData.Versiculos = obj.Versiculos;

        return bookEntityData;
    }

    public BookEntity MappingInputModelToEntity(BookInputModel obj)
    {
        BookEntity bookEntity = new BookEntity(obj.Nome, obj.Testamento, obj.AutorId, obj.Descricao, obj.Capitulos, obj.Versiculos);

        return bookEntity;
    }

    public List<BookEntity> MappingListEntityDataToListEntity(List<BookEntityData> obj)
    {
        List<BookEntity> bookEntities = new List<BookEntity>();
        obj.ForEach(item => bookEntities.Add(new BookEntity(item.Nome, item.Testamento, item. AutorId, item.Descricao, item.Capitulos, item.Versiculos)));

        return bookEntities;
    }

    public List<BookDto> MappingListEntityToListDto(List<BookEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<BookEntityData> MappingListEntityToListEntityData(List<BookEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<BookDto> Read(bool include = false)
    {
        var book = _repository.ReadAll<BookEntityData>().ToList();
        List<BookEntity> bookEntitiy = MappingListEntityDataToListEntity(book);

        //Chamando lista e mapeando objetos de PERSON
        PersonServices personServices = new PersonServices();
        var personData = _repository.ReadAll<PersonEntityData>().ToList();

        var personEntity = personServices.MappingListEntityDataToListEntity(personData);

        var personDto = personServices.MappingListEntityToListDto(personEntity);

        List<BookDto> bookDto = new List<BookDto>();

        //Retornar objetos do banco
        bookEntitiy?.ForEach(item => 
            bookDto.Add(
                new BookDto(item.Nome,
                 item.Testamento, 
                 item.AutorId, 
                 item.Descricao, 
                 personEntity.FirstOrDefault(x => x.Id == item.AutorId)?.Nome,
                 item.Capitulos,
                 item.Versiculos)));

        return bookDto;

    }

    public bool Update(int id, BookInputModel obj, bool include = false)
    {
        BookEntity bookEntity = MappingInputModelToEntity(obj);
        BookEntityData bookEntityData = MappingEntityToEntityData(bookEntity);
        bookEntityData.Id = id;

        _repository.Update<BookEntityData>(bookEntityData);

        return true;
    }
}