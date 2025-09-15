using Domain.Entities;

namespace Domain.Entities.Death;

public class DeathEntity : Entity
{
    public int IdPessoa { get; private set; }
    public int AnosVivencia { get; private set; }
    public string Causa { get; private set; }

    public DeathEntity(int idPessoa, int anosVivencia, string causa)
    {
        IdPessoa = idPessoa;
        AnosVivencia = anosVivencia;
        Causa = causa;
    }

}

