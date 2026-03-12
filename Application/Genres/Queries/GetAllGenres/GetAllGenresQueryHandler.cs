using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Queries;

public class GetAllGenresQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllGenresQuery, List<Genre>>
{
  public Task<List<Genre>> Handle(GetAllGenresQuery query, CancellationToken cancellationToken)
  {
    return unitOfWork.Genres.GetAllAsync();
  }
}
