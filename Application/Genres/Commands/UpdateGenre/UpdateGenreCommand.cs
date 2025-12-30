using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Application.Genres.Commands;

public class UpdateGenreCommand : IRequest<Genre>
{
    public required int ID { get; init; }
    public required string Label { get; init; }
}
