using PetBookstore.Experiment.Domain.SeedWork;

namespace PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

public class Genre : Entity, IAggregateRoot
{
    public string Label { get; set; } = string.Empty;
}
