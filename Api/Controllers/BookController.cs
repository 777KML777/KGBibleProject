namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IBookAppService _app;
        public BookController
        (
            IBookAppService app
        )
        {
            _app = app;
        }

        [HttpGet]
        public List<BookDto> Get() =>
            _app.Read();

        [HttpPost]
        public IActionResult Create(BookInputModel obj) =>
            Ok(_app.Create(obj));
    }
}