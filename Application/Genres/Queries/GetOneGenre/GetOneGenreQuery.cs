using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Application.Genres.Queries;

public class GetOneGenreQuery : IRequest<Genre>
{
    public required int ID { get; init; }
}
