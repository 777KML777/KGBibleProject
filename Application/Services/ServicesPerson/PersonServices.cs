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
        PersonEntity personEntity = MappingInputModelToEntity(obj);
        PersonEntityData personEntityData = MappingEntityToEntityData(personEntity);

        _repository.Create(personEntityData);
        return true;
    }

    public bool Delete(PersonInputModel obj, bool include = false)
    {
        throw new NotImplementedException();
    }

    public PersonDto GetById(int id, bool include = false)
    {
        var pessoa = _repository.GetById<PersonEntityData>(id);
        PersonEntity personEntity = MappingEntityDataToEntity(pessoa);
        PersonDto personDto = MappingEntityToDto(personEntity);

        return personDto;
    }

    public PersonEntity MappingEntityDataToEntity(PersonEntityData obj)
    {
        PersonEntity personEntity = new PersonEntity(obj.Nome, obj.Descricao, obj.Sexo);
        return personEntity;
    }

    public PersonDto MappingEntityToDto(PersonEntity obj)
    {
        PersonDto personDto = new PersonDto(obj.Nome, obj.Descricao, obj.Sexo);
        return personDto;
    }

    public PersonEntityData MappingEntityToEntityData(PersonEntity obj)
    {
        PersonEntityData personEntityData = new PersonEntityData();

        personEntityData.Nome = obj.Nome;
        personEntityData.Descricao = obj.Descricao;
        personEntityData.Sexo = obj.Sexo;

        return personEntityData;
    }

    public PersonEntity MappingInputModelToEntity(PersonInputModel obj)
    {
        PersonEntity personEntity = new PersonEntity(obj.Nome, obj.Descricao, obj.Sexo);
        return personEntity;
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

    public bool Update(int id, PersonInputModel obj, bool include = false)
    {
        var pessoa = _repository.GetById<PersonEntityData>(id);
        PersonEntity personEntity = MappingInputModelToEntity(obj);
        PersonEntityData personEntityData = MappingEntityToEntityData(personEntity);

        personEntityData.Id = pessoa.Id;
        personEntityData.Nome = obj.Nome;
        personEntityData.Descricao = obj.Descricao;
        personEntityData.Sexo = obj.Sexo;

        _repository.Update<PersonEntityData>(personEntityData);

        return true;
    }
}