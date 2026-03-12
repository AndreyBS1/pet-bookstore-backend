using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Books.Commands;

public class DeleteBookCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteBookCommand>
{
  public async Task Handle(DeleteBookCommand command, CancellationToken cancellationToken)
  {
    var book = await unitOfWork.Books.GetByIDAsync(command.ID);

    if (book is null)
      throw new NotFoundException($"Book with ID {command.ID} not found");

    unitOfWork.Books.Remove(book);

    await unitOfWork.SaveChangesAsync(cancellationToken);
  }
}
