using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Experiment.Application.Common.Exceptions;

namespace PetBookstore.Experiment.Application.Genres.Commands;

public class DeleteGenreCommandHandler(IGenreRepository genreRepository) : IRequestHandler<DeleteGenreCommand>
{
    public async Task Handle(DeleteGenreCommand command, CancellationToken cancellationToken)
    {
        var genre = await genreRepository.GetByIDAsync(command.ID);

        if (genre is null)
            throw new NotFoundException($"Genre with ID {command.ID} not found");

        genreRepository.Remove(genre);

        await genreRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
    }
}
