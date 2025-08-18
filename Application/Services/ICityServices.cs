using Application.Dtos;
using Application.Models;
using Domain.Entities.City;
using JsonFile.Repository; 

namespace Application.Services;

public interface ICityServices : IService<CityInputModel, CityDto, CityEntity, CityEntityData>
{
    
}