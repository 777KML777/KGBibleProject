namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    private readonly IPersonServices _services;
    public PersonController()
    {
        _services = new PersonServices();
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return null;
    // }

    [HttpGet]
    public List<PersonDto> Get() =>
        _services.Read();

    [HttpPost]
    public void Create(PersonInputModel personInputModel) =>
        _services.Create(personInputModel);

    [HttpGet("{id}")]
    public PersonDto GetById(int id) =>
        _services.GetById(id);

    [HttpPut("{id}")]
    public void Update(int id, PersonInputModel personInputModel) =>
        _services.Update(id, personInputModel);

}