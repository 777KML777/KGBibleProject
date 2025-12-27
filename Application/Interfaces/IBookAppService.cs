using Domain.Dtos;
using Application.Inputs;

namespace Application.Interfaces;

public interface IBookAppService
{
    public BookDto Create(BookInputModel input);
    public List<BookDto> Read();
}