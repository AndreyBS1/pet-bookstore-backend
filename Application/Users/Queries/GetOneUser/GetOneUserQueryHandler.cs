using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.UserAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Users.Queries;

public class GetOneUserQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetOneUserQuery, User>
{
  public async Task<User> Handle(GetOneUserQuery query, CancellationToken cancellationToken)
  {
    var user = await unitOfWork.Users.GetByIDAsync(query.ID);

    if (user is null)
      throw new NotFoundException($"User with ID {query.ID} not found");

    return user;
  }
}
