using MediatR;
using PetBookstore.Domain.AggregatesModel.UserAggregate;

namespace PetBookstore.Application.Users.Commands;

public class UpdateUserCommand : IRequest<User>
{
  public required int ID { get; init; }
  public required string Name { get; init; }
}
