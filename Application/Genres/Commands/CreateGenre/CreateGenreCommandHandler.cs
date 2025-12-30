using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Commands;

public class CreateGenreCommandHandler(IGenreRepository genreRepository) : IRequestHandler<CreateGenreCommand, Genre>
{
    public async Task<Genre> Handle(CreateGenreCommand command, CancellationToken cancellationToken)
    {
        var genre = new Genre
        {
            Label = command.Label
        };

        genreRepository.Add(genre);

        await genreRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return genre;
    }
}
