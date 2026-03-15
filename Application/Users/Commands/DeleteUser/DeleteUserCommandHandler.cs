using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Users.Commands;

public class DeleteUserCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteUserCommand>
{
  public async Task Handle(DeleteUserCommand command, CancellationToken cancellationToken)
  {
    var user = await unitOfWork.Users.GetByIDAsync(command.ID);

    if (user is null)
      throw new NotFoundException($"User with ID {command.ID} not found");

    unitOfWork.Users.Remove(user);

    await unitOfWork.SaveChangesAsync(cancellationToken);
  }
}
