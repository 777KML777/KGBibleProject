using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace KGBibleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {

        private readonly ICityServices _services;
        public CityController()
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