using Application.Dtos;
using Application.Models;
using Domain.Entities.Person;
using Infra.Data; 

namespace Application.Services.ServicesPerson;

public interface IPersonServices : IService<PersonInputModel, PersonDto, PersonEntity, PersonEntityData>
{
    
}