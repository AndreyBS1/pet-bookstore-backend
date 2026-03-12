using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Commands;

public class CreateGenreCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateGenreCommand, Genre>
{
  public async Task<Genre> Handle(CreateGenreCommand command, CancellationToken cancellationToken)
  {
    var genre = new Genre
    {
      Label = command.Label
    };

    unitOfWork.Genres.Add(genre);

    await unitOfWork.SaveChangesAsync(cancellationToken);

    return genre;
  }
}
