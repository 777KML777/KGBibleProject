namespace Domain.Base.Class;

public class Entity
{
    public int Id { get; protected set; }
    public void SetId(int identifier) => Id = identifier;
}