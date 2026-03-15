using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.UserAggregate;

namespace PetBookstore.Application.Users.Queries;

public class GetUserRangeQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetUserRangeQuery, List<User>>
{
  public Task<List<User>> Handle(GetUserRangeQuery query, CancellationToken cancellationToken)
  {
    return unitOfWork.Users.GetRangeAsync(query.Offset, query.Limit);
  }
}
