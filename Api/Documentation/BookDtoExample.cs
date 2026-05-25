namespace Api.Documentation;

public class BookDtoExample : IExamplesProvider<BookInputModel>
{
    public BookInputModel GetExamples()
    {
        return new BookInputModel
        (
            new
            (
                0,
                DateTime.Now,
                DateTime.Now,
                DateTime.Now,
                [],
                "",
                "",
                "",
                0
            )
            { Character = null }
        );
    }
}