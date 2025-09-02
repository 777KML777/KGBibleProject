using Application.Dtos;
using Application.Models;
using Domain.Entities.Death;
using Domain.Entities.Person;
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
        DeathEntity deathEntity = MappingInputModelToEntity(obj);
        DeathEntityData deathEntityData = MappingEntityToEntityData(deathEntity);

        _repository.Create(deathEntityData);

        return true;
    }

    public bool Delete(DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public DeathDto GetById(int id, bool include = false)
    {
        var deathData = _repository.GetById<DeathEntityData>(id);
        DeathEntity deathEntity = MappingEntityDataToEntity(deathData);
        DeathDto deathDto = MappingEntityToDto(deathEntity);

        var personData = _repository.GetById<PersonEntityData>(deathData.IdPessoa);

        return deathDto;

    }

    public DeathEntity MappingEntityDataToEntity(DeathEntityData obj)
    {
        DeathEntity deathEntity = new DeathEntity(obj.IdPessoa, obj.AnosVicencia, obj.Causa);
        return deathEntity;
    }

    public DeathDto MappingEntityToDto(DeathEntity obj)
    {
        DeathDto deathDto = new DeathDto(obj.IdPessoa, obj.AnosVicencia, obj.Causa);
        return deathDto;
    }

    public DeathEntityData MappingEntityToEntityData(DeathEntity obj)
    {
        DeathEntityData deathEntityData = new DeathEntityData();

        deathEntityData.IdPessoa = obj.IdPessoa;
        deathEntityData.AnosVicencia = obj.AnosVicencia;
        deathEntityData.Causa = obj.Causa;

        return deathEntityData;
    }

    public DeathEntity MappingInputModelToEntity(DeathInputModel obj)
    {
        DeathEntity deathEntity = new DeathEntity(obj.IdPessoa, obj.AnosVicencia, obj.Causa);
        return deathEntity;
    }

    public List<DeathEntity> MappingListEntityDataToListEntity(List<DeathEntityData> obj)
    {
        List<DeathEntity> deathEntities = new List<DeathEntity>();

        obj.ForEach(item => deathEntities.Add(new DeathEntity(item.IdPessoa, item.AnosVicencia, item.Causa)));

        return deathEntities;
    }

    public List<DeathDto> MappingListEntityToListDto(List<DeathEntity> obj)
    {
        List<DeathDto> deathDto = new List<DeathDto>();
        obj.ForEach(item => deathDto.Add(new DeathDto(item.IdPessoa, item.AnosVicencia, item.Causa)));

        return deathDto;
    }

    public List<DeathEntityData> MappingListEntityToListEntityData(List<DeathEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<DeathDto> Read(bool include = false)
    {
        var death = _repository.ReadAll<DeathEntityData>().ToList();

        List<DeathEntity> deathEntity = MappingListEntityDataToListEntity(death);

        List<DeathDto> deathDto = MappingListEntityToListDto(deathEntity);

        return deathDto;
    }

    public bool Update(int id, DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }
}