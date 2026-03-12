namespace PetBookstore.Domain.SeedWork;

public abstract class Entity
{
  public int ID { get; init; }

  public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
