using PetBookstore.Experiment.Domain.SeedWork;

namespace PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

public class Book : Entity, IAggregateRoot
{
    public required string Title { get; init; } = string.Empty;
    public required string Author { get; init; } = string.Empty;
    public required decimal Price { get; init; }
    public required int Quantity { get; init; }
}
