using PetBookstore.Domain.SeedWork;

namespace PetBookstore.Domain.AggregatesModel.GenreAggregate;

public class Genre : Entity, IAggregateRoot
{
    public string Label { get; set; } = string.Empty;
}
