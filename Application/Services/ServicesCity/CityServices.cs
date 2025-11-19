using Application.Dtos;
using Application.Models;
using Domain.Entities.City;
using JsonFile.Repository;
using JsonFile.Repository.CityRepository;

namespace Application.Services.ServicesCity;

public class CityServices : ICityServices
{
    private readonly ICityRepository _repository;
    public CityServices()
    {
        _repository = new CityRepository();
    }
    public bool Create(CityInputModel obj, bool include = false)
    {
        CityEntity cityEntity = MappingInputModelToEntity(obj);
        CityEntityData cityEntityData = MappingEntityToEntityData(cityEntity);
        _repository.Create(cityEntityData);
        return true;
    }

    public bool Delete(CityInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public CityDto GetById(int id, bool include = false)
    {
        var cidade = _repository.GetById<CityEntityData>(id);

        CityEntity cityEntity = MappingEntityDataToEntity(cidade);

        CityDto cityDto = MappingEntityToDto(cityEntity);

        return cityDto;

    }

    public CityEntity MappingEntityDataToEntity(CityEntityData obj)
    {
        CityEntity cityEntity = new CityEntity(obj.Nome, obj.Descricao);
        return cityEntity;

    }

    public CityDto MappingEntityToDto(CityEntity obj)
    {
        CityDto cityDto = new CityDto(obj.Nome, obj.Descricao);
        return cityDto;

    }

    public CityEntityData MappingEntityToEntityData(CityEntity obj)
    {
        CityEntityData cityEntityData = new CityEntityData();
        cityEntityData.Nome = obj.Nome;
        cityEntityData.Descricao = obj.Descricao;

        return cityEntityData;
    }

    public CityEntity MappingInputModelToEntity(CityInputModel obj)
    {
        CityEntity cityEntity = new CityEntity(obj.Nome, obj.Descricao);
        return cityEntity;
    }

    public List<CityEntity> MappingListEntityDataToListEntity(List<CityEntityData> obj)
    {
        List<CityEntity> cities = new List<CityEntity>();
        obj.ForEach(item => cities.Add(new CityEntity(item.Nome, item.Descricao)));
        return cities;
    }

    public List<CityDto> MappingListEntityToListDto(List<CityEntity> obj)
    {
        List<CityDto> cities = new List<CityDto>();
        obj.ForEach(item => cities.Add(new CityDto(item.Nome, item.Descricao)));
        return cities;
    }

    public List<CityEntityData> MappingListEntityToListEntityData(List<CityEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<CityDto> Read(bool include = false)
    {
        // _repository.ReadAll<CityEntityData>();
        //    var y = MappingListEntityToListDto(new List<CityEntity>());
        var y = MappingListEntityToListDto
        (
            MappingListEntityDataToListEntity
            (
                _repository.ReadAll<CityEntityData>().ToList()
            )
        );
        return y;
    }

    public bool Update(int id, CityInputModel obj, bool include = false)
    {
        CityEntity cityEntity = MappingInputModelToEntity(obj);
        CityEntityData cityEntityData = MappingEntityToEntityData(cityEntity);

        cityEntityData.Id = id;
        
        _repository.Update(cityEntityData);
        return true;
    }
}