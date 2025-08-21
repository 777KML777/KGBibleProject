using Application.Dtos;
using Application.Models;
using Domain.Entities.City;
using JsonFile.Repository; 

namespace Application.Services.ServicesCity;

public interface ICityServices : IService<CityInputModel, CityDto, CityEntity, CityEntityData>
{
    
}