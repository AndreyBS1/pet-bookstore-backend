namespace PetBookstore.Experiment.Domain.SeedWork;

public abstract class Entity
{
    public int ID { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
