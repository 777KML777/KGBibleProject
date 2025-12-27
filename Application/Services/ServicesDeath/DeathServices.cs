using System.Data;
using Application.Dtos;
using Application.Models;
using Application.Services.ServicesPerson;
using Domain.Entities.Death;
using Domain.Entities.Person;
using Infra.Data;
using Infra.Data.DeathRepository;
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

    public bool Delete(int id, DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public bool Delete(DeathInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public DeathDto GetById(int id, bool include = false)
    {
        var deathData = _repository.GetById<DeathEntityData>(id);
        DeathEntity deathEntity = MappingEntityDataToEntity(deathData);

        var personData = _repository.GetById<PersonEntityData>(deathData.IdPessoa);

        PersonServices personServices = new PersonServices();
        var personEntity = personServices.MappingEntityDataToEntity(personData);
        var personDto = personServices.MappingEntityToDto(personEntity);

        DeathDto deathDto = new DeathDto(deathEntity.IdPessoa, deathEntity.AnosVivencia, deathEntity.Causa, personDto.Nome);

        return deathDto;

    }

    public DeathEntity MappingEntityDataToEntity(DeathEntityData obj)
    {
        DeathEntity deathEntity = new DeathEntity(obj.IdPessoa, obj.AnosVivencia, obj.Causa);
        return deathEntity;
    }

    public DeathDto MappingEntityToDto(DeathEntity obj)
    {
        throw new NotImplementedException();
    }

    public DeathEntityData MappingEntityToEntityData(DeathEntity obj)
    {
        DeathEntityData deathEntityData = new DeathEntityData();

        deathEntityData.IdPessoa = obj.IdPessoa;
        deathEntityData.AnosVivencia = obj.AnosVivencia;
        deathEntityData.Causa = obj.Causa;

        return deathEntityData;
    }

    public DeathEntity MappingInputModelToEntity(DeathInputModel obj)
    {
        DeathEntity deathEntity = new DeathEntity(obj.IdPessoa, obj.AnosVivencia, obj.Causa);
        return deathEntity;
    }

    public List<DeathEntity> MappingListEntityDataToListEntity(List<DeathEntityData> obj)
    {
        List<DeathEntity> deathEntities = new List<DeathEntity>();

        obj.ForEach(item => deathEntities.Add(new DeathEntity(item.IdPessoa, item.AnosVivencia, item.Causa)));

        return deathEntities;
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
        var death = _repository.ReadAll<DeathEntityData>().ToList();
        List<DeathEntity> deathEntity = MappingListEntityDataToListEntity(death);


        PersonServices personServices = new PersonServices();
        var personData = _repository.ReadAll<PersonEntityData>().ToList();

        var personEntity = personServices.MappingListEntityDataToListEntity(personData);

        var personDto = personServices.MappingListEntityToListDto(personEntity);

        List<DeathDto> deathDto = new List<DeathDto>();
        //Primeiramente retornar os obj do banco 
        deathEntity?.ForEach(item => deathDto.Add(new DeathDto(item.IdPessoa, item.AnosVivencia, item.Causa, personEntity.FirstOrDefault(x => x.Id == item.IdPessoa)?.Nome)));


        return deathDto;
    }

    public bool Update(int id, DeathInputModel obj, bool include = false)
    {
        DeathEntity deathEntity = MappingInputModelToEntity(obj);
        DeathEntityData deathEntityData = MappingEntityToEntityData(deathEntity);

        deathEntityData.Id = id;

        _repository.Update<DeathEntityData>(deathEntityData);

        return true;
    }
}