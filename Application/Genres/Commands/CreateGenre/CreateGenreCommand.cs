using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Application.Genres.Commands;

public class CreateGenreCommand : IRequest<Genre>
{
    public required string Label { get; init; }
}
