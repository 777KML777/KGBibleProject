using Swashbuckle.AspNetCore.Filters;

namespace Api.Documentation;
public class BookDtoExample : IExamplesProvider<BookInputModel>
{
    public BookInputModel GetExamples()
    {
        return new BookInputModel
        {
            Book = new
            (
                0,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                [],
                "",
                "",
                ""
            )
            { Character = null }
        };
    }
}