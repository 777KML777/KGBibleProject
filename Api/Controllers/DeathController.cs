using Application.Dtos;
using Application.Models;
using Application.Services.ServicesDeath;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeathController : ControllerBase
    {

        private readonly IDeathServices _services;
        public DeathController()
        {
            _services = new DeathServices();
        }

        // [HttpGet(Name = "GetWeatherForecast")]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     return null;
        // }
    }
}       



