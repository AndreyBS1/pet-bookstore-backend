using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.UserAggregate;

namespace PetBookstore.Application.Users.Commands;

public class CreateUserCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateUserCommand, User>
{
  public async Task<User> Handle(CreateUserCommand command, CancellationToken cancellationToken)
  {
    var user = new User
    {
      Role = command.Role,
      Name = command.Name,
      Email = command.Email,
      Password = command.Password,
    };

    unitOfWork.Users.Add(user);

    await unitOfWork.SaveChangesAsync(cancellationToken);

    return user;
  }
}
