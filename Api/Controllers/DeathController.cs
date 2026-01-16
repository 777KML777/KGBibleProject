// using Application.Services.ServicesDeath;

// namespace Api.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class DeathController : ControllerBase
//     {

//         private readonly IDeathServices _services;
//         public DeathController()
//         {
//             _services = new DeathServices();
//         }

//         // [HttpGet(Name = "GetWeatherForecast")]
//         // public IEnumerable<WeatherForecast> Get()
//         // {
//         //     return null;
//         // }

//         [HttpGet]
//         public List<DeathDto> Get() =>
//             _services.Read();

//         [HttpPost]
//         public void Create(DeathInputModel deathInputModel) =>
//             _services.Create(deathInputModel);

//         [HttpGet("{id}")]
//         public DeathDto GetById(int id) =>
//             _services.GetById(id);

//         [HttpPut("{id}")]
//         public void Update(int id, DeathInputModel deathInputModel) =>
//             _services.Update(id, deathInputModel);
//     }
// }       



