using Domain.Dtos;
using Application.Inputs;

namespace Application.Interfaces;

public interface IBookAppService
{
    public BookDto Create(BookInputModel input);
    public List<BookDto> Read();
    public BookDto GetById(int identifier);
    public BookDto Update(int identifier, BookInputModel dto);
    public bool Delete(int identifier);
}