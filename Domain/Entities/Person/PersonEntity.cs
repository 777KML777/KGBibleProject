namespace Domain.Entities.Person;

public class PersonEntity : Entity
{

    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public string Sexo { get; private set; }

    public PersonEntity(string nome, string descricao, string sexo)
    {
        Nome = nome;
        Descricao = descricao;
        Sexo = sexo;
    }
    
      
}



