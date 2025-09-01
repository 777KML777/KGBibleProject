using Domain.Entities;

namespace Domain.Entities.Death;

public class DeathEntity : Entity
{
    public int IdPessoa { get; private set; }
    public int AnosVicencia { get; private set; }
    public string Causa { get; private set; }

    public DeathEntity(int idPessoa, int anosVivencia, string causa)
    {
        IdPessoa = idPessoa;
        AnosVicencia = anosVivencia;
        Causa = causa;
    }

}

