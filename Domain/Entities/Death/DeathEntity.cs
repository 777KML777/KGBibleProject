using Domain.Entities;

namespace Domain.Entities.Death;

public class DeathEntity : Entity
{
    public int IdPessoa { get; set; }
    public int AnosVicencia { get; set; }
    public string Causa { get; set; }

    public DeathEntity(int id, int idPessoa, int anosVivencia, string causa)
    {
        Id = id;
        IdPessoa = idPessoa;
        AnosVicencia = anosVivencia;
        Causa = causa;
    }

}

