using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Queries;

public class GetOneGenreQuery : IRequest<Genre>
{
    public required int ID { get; init; }
}
