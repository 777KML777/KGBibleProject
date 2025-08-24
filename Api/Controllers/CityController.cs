using Application.Dtos;
using Application.Models;
using Application.Services.ServicesCity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
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

        [HttpPost]
        public void Create(CityInputModel cityInputModel) =>
            _services.Create(cityInputModel);

        [HttpGet]
        public CityDto GetById(int id) =>
            _services.GetById(id);
    }
}