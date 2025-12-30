using MediatR;

namespace PetBookstore.Application.Genres.Commands;

public class DeleteGenreCommand : IRequest
{
    public required int ID { get; init; }
}
