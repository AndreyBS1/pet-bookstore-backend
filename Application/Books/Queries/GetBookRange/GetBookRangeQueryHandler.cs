using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Application.Books.Queries;

public class GetBookRangeQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetBookRangeQuery, List<Book>>
{
  public Task<List<Book>> Handle(GetBookRangeQuery query, CancellationToken cancellationToken)
  {
    return unitOfWork.Books.GetRangeAsync(query.Offset, query.Limit);
  }
}
