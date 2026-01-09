using Application.Services.ServicesCharacter;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{

    private readonly ICharacterServices _services;
    public CharacterController()
    {
        _services = new CharacterServices();
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return null;
    // }

    [HttpGet]
    public List<CharacterDto> Get() =>
        _services.Read();

    [HttpPost]
    public void Create(CharacterInputModel characterInputModel) =>
        _services.Create(characterInputModel);

    [HttpGet("{id}")]
    public CharacterDto GetById(int id) =>
        _services.GetById(id);

    [HttpPut("{id}")]
    public void Update(int id, CharacterInputModel characterInputModel) =>
        _services.Update(id, characterInputModel);

}