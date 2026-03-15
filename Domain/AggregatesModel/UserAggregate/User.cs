using PetBookstore.Domain.SeedWork;

namespace PetBookstore.Domain.AggregatesModel.UserAggregate;

public class User : Entity, IAggregateRoot
{
  public UserRole Role { get; set; } = UserRole.Basic;
  public string Name { get; set; } = string.Empty;
  public string Email { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
}
