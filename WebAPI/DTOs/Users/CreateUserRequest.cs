using PetBookstore.Domain.AggregatesModel.UserAggregate;

namespace PetBookstore.WebAPI.DTOs.Users;

public class CreateUserRequest
{
  public required UserRole Role { get; init; }
  public required string Name { get; init; }
  public required string Email { get; init; }
  public required string Password { get; init; }
}
