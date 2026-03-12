using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Commands;

public class UpdateGenreCommand : IRequest<Genre>
{
  public required int ID { get; init; }
  public required string Label { get; init; }
}
