using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Genres.Commands;

public class UpdateGenreCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateGenreCommand, Genre>
{
  public async Task<Genre> Handle(UpdateGenreCommand command, CancellationToken cancellationToken)
  {
    var genre = await unitOfWork.Genres.GetByIDAsync(command.ID);

    if (genre is null)
      throw new NotFoundException($"Genre with ID {command.ID} not found");

    genre.Label = command.Label;

    await unitOfWork.SaveChangesAsync(cancellationToken);

    return genre;
  }
}
