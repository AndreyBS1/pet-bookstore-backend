using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Genres.Commands;

public class DeleteGenreCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteGenreCommand>
{
  public async Task Handle(DeleteGenreCommand command, CancellationToken cancellationToken)
  {
    var genre = await unitOfWork.Genres.GetByIDAsync(command.ID);

    if (genre is null)
      throw new NotFoundException($"Genre with ID {command.ID} not found");

    unitOfWork.Genres.Remove(genre);

    await unitOfWork.SaveChangesAsync(cancellationToken);
  }
}
