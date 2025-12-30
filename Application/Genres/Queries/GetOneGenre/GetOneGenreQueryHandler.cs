using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Genres.Queries;

public class GetOneGenreQueryHandler(IGenreRepository repository) : IRequestHandler<GetOneGenreQuery, Genre>
{
    private readonly IGenreRepository _repository = repository;

    public async Task<Genre> Handle(GetOneGenreQuery query, CancellationToken cancellationToken)
    {
        var genre = await _repository.GetByIDAsync(query.ID);
        if (genre is null)
            throw new NotFoundException($"Genre with ID {query.ID} not found");
        return genre;
    }
}
