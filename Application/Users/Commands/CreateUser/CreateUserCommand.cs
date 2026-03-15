using MediatR;
using PetBookstore.Domain.AggregatesModel.UserAggregate;

namespace PetBookstore.Application.Users.Commands;

public class CreateUserCommand : IRequest<User>
{
  public required UserRole Role { get; init; }
  public required string Name { get; init; }
  public required string Email { get; init; }
  public required string Password { get; init; }
}
