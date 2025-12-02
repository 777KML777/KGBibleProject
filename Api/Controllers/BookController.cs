using Application.Dtos;
using Application.Models;
using Application.Services.ServicesBook;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IBookServices _services;
        public BookController()
        {
            _services = new BookServices();
        }

        // [HttpGet(Name = "GetWeatherForecast")]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     return null;
        // }
        [HttpGet]
        public List<BookDto> Get() =>
            _services.Read();

        [HttpPost]
        public void Create(BookInputModel obj) =>
            _services.Create(obj);

        [HttpGet("{id}")]
        public BookDto Get(int id) =>
            _services.GetById(id);
        
        [HttpPut("{id}")]
        public void Update(int id, BookInputModel obj) =>
            _services.Update(id, obj);
    }
}