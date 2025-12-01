using Application.Dtos;
using Application.Models;
using Domain.Entities.Book;
using JsonFile.Repository; 

namespace Application.Services.ServicesBook;

public interface IBookServices : IService<BookInputModel, BookDto, BookEntity, BookEntityData>
{
    
}