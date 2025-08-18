using Application.Dtos;
using Application.Models;
using Domain.Entities.City;
using JsonFile.Repository;
using JsonFile.Repository.CityRepository;

namespace Application.Services;

public class CityServices : ICityServices
{
    private readonly ICityRepository _repository;
    public CityServices()
    {
        _repository = new CityRepository();
    }
    public bool Create(CityInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public bool Delete(CityInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public CityDto GetById(int id, bool include = false)
    {
        throw new NotImplementedException();
    }

    public CityEntity MappingEntityDataToEntity(CityEntityData obj)
    {
        throw new NotImplementedException();
    }

    public CityDto MappingEntityToDto(CityEntity obj)
    {
        throw new NotImplementedException();
    }

    public CityEntityData MappingEntityToEntityData(CityEntity obj)
    {
        throw new NotImplementedException();
    }

    public CityEntity MappingInputModelToEntity(CityInputModel obj)
    {
        throw new NotImplementedException();
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

    public bool Update(CityInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }
}