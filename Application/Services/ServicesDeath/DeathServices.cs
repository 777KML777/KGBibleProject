using Application.Dtos;
using Application.Models;
using Domain.Entities.Death;
using JsonFile.Repository;
using JsonFile.Repository.DeathRepository;
using JsonFile.Repositoy;

namespace Application.Services.ServicesDeath;

public class DeathServices : IDeathServices
{
    private readonly IDeathRepository _repository;
    public DeathServices()
    {
        _repository = new DeathRepository();
    }
    public bool Create(DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public bool Delete(DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public DeathDto GetById(int id, bool include = false)
    {
        throw new NotImplementedException();
    }

    public DeathEntity MappingEntityDataToEntity(DeathEntityData obj)
    {   
        throw new NotImplementedException();
    }

    public DeathDto MappingEntityToDto(DeathEntity obj)
    {
        throw new NotImplementedException();
    }

    public DeathEntityData MappingEntityToEntityData(DeathEntity obj)
    {
        throw new NotImplementedException();
    }

    public DeathEntity MappingInputModelToEntity(DeathInputModel obj)
    {
        throw new NotImplementedException();
    }

    public List<DeathEntity> MappingListEntityDataToListEntity(List<DeathEntityData> obj)
    {
        throw new NotImplementedException();
    }

    public List<DeathDto> MappingListEntityToListDto(List<DeathEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<DeathEntityData> MappingListEntityToListEntityData(List<DeathEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<DeathDto> Read(bool include = false)
    {
        throw new NotImplementedException();
    }

    public bool Update(int id, DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }
}