namespace Domain.Services;

public class BookService
(
    IBookRepository _repository
) : IBookService
{
    public BookDto Create(BookDto input)
    {

        BookEntity entity = _repository.GetByName(input.Nome);

        if (entity != null && entity.Name.Equals(input.Nome))
            throw new BookAlreadyExistDomainException(input.Nome);

        return _repository.Create(input.ToEntity()).ToDto(); ;
    }


    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public BookDto GetById(int id)
    {
        try
        {
            BookEntity entity = _repository.GetById(id);
            return entity.ToDto();
        }
        catch (Exception e)
        {
            throw new NotFoundDomainException("BOOK", e.Message);
        }
    }

    public IEnumerable<BookDto> Read()
    {
        // TODO: Ter a quantidade de autores que escreveram o livro. 
        return [.. _repository.Read().ToDto()];
    }
    public BookDto Update(BookDto dto)
    {
        BookEntity entity = _repository.GetById(dto.Id);
        entity.Alterar(dto.ToEntity());

        return _repository.Update(entity).ToDto();
    }
}