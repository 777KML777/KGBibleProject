using Application.Dtos;
using Application.Models;
using Domain.Entities.Person;
using JsonFile.Repository;
using JsonFile.Repository.PersonRepository;

namespace Application.Services.ServicesPerson;

public class PersonServices : IPersonServices
{
    private readonly IPersonRepository _repository;
    public PersonServices()
    {
        _repository = new PersonRepository();
    }
    public bool Create(PersonInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public bool Delete(PersonInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public PersonDto GetById(int id, bool include = false)
    {
        throw new NotImplementedException();
    }

    public PersonEntity MappingEntityDataToEntity(PersonEntityData obj)
    {
        throw new NotImplementedException();
    }

    public PersonDto MappingEntityToDto(PersonEntity obj)
    {
        throw new NotImplementedException();
    }

    public PersonEntityData MappingEntityToEntityData(PersonEntity obj)
    {
        throw new NotImplementedException();
    }

    public PersonEntity MappingInputModelToEntity(PersonInputModel obj)
    {
        throw new NotImplementedException();
    }

    public List<PersonEntity> MappingListEntityDataToListEntity(List<PersonEntityData> obj)
    {
        List<PersonEntity> peoples = new List<PersonEntity>();
        obj.ForEach(item => peoples.Add(new PersonEntity(item.Nome, item.Descricao, item.Sexo)));
        return peoples;
    }

    public List<PersonDto> MappingListEntityToListDto(List<PersonEntity> obj)
    {
        List<PersonDto> peoples = new List<PersonDto>();
        obj.ForEach(item => peoples.Add(new PersonDto(item.Nome, item.Descricao, item.Sexo)));
        return peoples;
    }

    public List<PersonEntityData> MappingListEntityToListEntityData(List<PersonEntity> obj)
    {
        throw new NotImplementedException();
    }

    public List<PersonDto> Read(bool include = false)
    {
        // _repository.ReadAll<PersonEntityData>();
        //    var y = MappingListEntityToListDto(new List<PersonEntity>());
        var y = MappingListEntityToListDto
        (
            MappingListEntityDataToListEntity
            (
                 _repository.ReadAll<PersonEntityData>().ToList()
            )
        );
        return y;
    }

    public bool Update(PersonInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }
}