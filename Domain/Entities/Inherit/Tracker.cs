namespace Domain.Entities.Inherit;
public class Tracker : Entity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public List<DateTime> UpdateAt { get; set; } = []; 
}