using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Commands;

public class CreateGenreCommand : IRequest<Genre>
{
    public required string Label { get; init; }
}
