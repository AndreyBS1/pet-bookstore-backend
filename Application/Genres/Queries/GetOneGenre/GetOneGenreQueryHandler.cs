using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Genres.Queries;

public class GetOneGenreQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetOneGenreQuery, Genre>
{
  public async Task<Genre> Handle(GetOneGenreQuery query, CancellationToken cancellationToken)
  {
    var genre = await unitOfWork.Genres.GetByIDAsync(query.ID);

    if (genre is null)
      throw new NotFoundException($"Genre with ID {query.ID} not found");

    return genre;
  }
}
