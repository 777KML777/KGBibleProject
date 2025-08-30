using Application.Dtos;
using Application.Models;
using Domain.Entities.Death;
using JsonFile.Repositoy;

namespace Application.Services.ServicesDeath;

public interface IDeathServices : IService<DeathInputModel, DeathDto, DeathEntity, DeathEntityData>
{
    
}