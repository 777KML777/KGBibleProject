namespace Domain.Entities;

public class BookEntity : Tracker
{

    public BookEntity(string name, string testament, string description)
    {
        CreatedAt = DateTime.Now;
        Name = name;
        Description = description;
        Testament = testament;

    }
    public string Name { get; private set; }
    public string Testament { get; private set; }
    public string Description { get; private set; }
}