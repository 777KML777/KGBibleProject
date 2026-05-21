namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController
(
    IBookAppService _app
) : ControllerBase
{

    [HttpGet]
    public IActionResult Get() => Ok(_app.Read());

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdInput input) => Ok(await _app.GetById(input));

    [HttpPost]
    [SwaggerRequestExample(typeof(BookInputModel), typeof(BookDtoExample))]
    public IActionResult Create(BookInputModel input) => Ok(_app.Create(input));

    [HttpPut("{id}")]
    public IActionResult Update(int id, BookInputModel dto) => Ok(_app.Update(id, dto));

    [HttpDelete("{id}")]
    public IActionResult Delete(int id) => Ok(_app.Delete(id));
}