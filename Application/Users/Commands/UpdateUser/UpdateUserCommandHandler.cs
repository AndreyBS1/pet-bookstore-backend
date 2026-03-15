using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.UserAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Users.Commands;

public class UpdateUserCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateUserCommand, User>
{
  public async Task<User> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
  {
    var user = await unitOfWork.Users.GetByIDAsync(command.ID);

    if (user is null)
      throw new NotFoundException($"User with ID {command.ID} not found");

    user.Name = command.Name;

    await unitOfWork.SaveChangesAsync(cancellationToken);

    return user;
  }
}
