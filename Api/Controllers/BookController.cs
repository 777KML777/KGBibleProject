namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController
(
    IBookAppService _app
) : ControllerBase
{

    // [ApiExplorerSettings(GroupName = "2")]
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdInput input) => Ok(await _app.GetById(input));

    [HttpPost]
    [SwaggerRequestExample(typeof(BookInputModel), typeof(BookDtoExample))]
    public IActionResult Create(BookInputModel input) => Ok(_app.Create(input));

    // [ApiExplorerSettings(GroupName = "1")]
    [HttpGet]
    public IActionResult Get() => Ok(_app.Read());
    [HttpPut()]
    public IActionResult Update(BookInputModel dto) => Ok(_app.Update(dto));

    [HttpDelete("{id}")]
    public IActionResult Delete(int id) => Ok(_app.Delete(id));
}