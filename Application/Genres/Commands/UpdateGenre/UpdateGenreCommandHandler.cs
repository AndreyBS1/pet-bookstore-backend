using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Experiment.Application.Common.Exceptions;

namespace PetBookstore.Experiment.Application.Genres.Commands;

public class UpdateGenreCommandHandler(IGenreRepository genreRepository) : IRequestHandler<UpdateGenreCommand, Genre>
{
    public async Task<Genre> Handle(UpdateGenreCommand command, CancellationToken cancellationToken)
    {
        var genre = await genreRepository.GetByIDAsync(command.ID);

        if (genre is null)
            throw new NotFoundException($"Genre with ID {command.ID} not found");

        genre.Label = command.Label;

        await genreRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return genre;
    }
}
