using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Application.Genres.Queries;

public class GetAllGenresQueryHandler(IGenreRepository repository) : IRequestHandler<GetAllGenresQuery, List<Genre>>
{
    private readonly IGenreRepository _repository = repository;

    public Task<List<Genre>> Handle(GetAllGenresQuery query, CancellationToken cancellationToken)
    {
        return _repository.GetAllAsync();
    }
}
