using MediatR;

namespace PetBookstore.Experiment.Application.Genres.Commands;

public class DeleteGenreCommand : IRequest
{
    public required int ID { get; init; }
}
