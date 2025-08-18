using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace KGBibleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ICityServices _services;
        public PersonController()
        {
            _services = new CityServices();
        }

        // [HttpGet(Name = "GetWeatherForecast")]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     return null;
        // }

        [HttpGet]
        public List<CityDto> Get() =>
            _services.Read(); 
    }
}