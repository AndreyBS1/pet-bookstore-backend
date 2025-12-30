using PetBookstore.Experiment.Domain.SeedWork;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

public class Book : Entity, IAggregateRoot
{
    public required string Title { get; init; } = string.Empty;
    public required string Author { get; init; } = string.Empty;
    public required decimal Price { get; init; }
    public required int Quantity { get; init; }

    public List<Genre> Genres { get; init; } = new List<Genre>();
}
