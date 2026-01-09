using Domain.Base.Class;

namespace Domain.Entities.Character;

public class CharacterEntity : Entity
{

    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public string Sexo { get; private set; }

    public CharacterEntity(string nome, string descricao, string sexo)
    {
        Nome = nome;
        Descricao = descricao;
        Sexo = sexo;
    }
    
      
}



