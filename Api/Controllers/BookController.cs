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
        public IActionResult Get() =>
            Ok(_app.Read());

        [HttpPost]
        public IActionResult Create(BookInputModel input) =>
            Ok(_app.Create(input));

        [HttpGet("{id}")]
        public IActionResult GetById(int id) =>
            Ok(_app.GetById(id));

        [HttpPut("{id}")]
        public IActionResult Update(int id, BookInputModel dto) =>
            Ok(_app.Update(id, dto));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) =>
            Ok(_app.Delete(id));
    }
}