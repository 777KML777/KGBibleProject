using Domain.Base.Class;

namespace Domain.Entities;

public class CharacterEntity
(
    
) : Entity
{

    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public string Sexo { get; private set; }
    public string Plano { get; set; }
    public string Tipo { get; set; }

    public CharacterEntity(string nome, string descricao, string sexo, string plano, string tipo) : this()
    {
        Nome = nome;
        Descricao = descricao;
        Sexo = sexo;
        Tipo = tipo;
        Plano = plano;
    }      
}



