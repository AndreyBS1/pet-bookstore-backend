using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Experiment.Application.Queries;

public class GetBookRangeQueryHandler(IBookRepository repository) : IRequestHandler<GetBookRangeQuery, List<Book>>
{
    private readonly IBookRepository _repository = repository;

    public Task<List<Book>> Handle(GetBookRangeQuery query, CancellationToken cancellationToken)
    {
        return _repository.GetRangeAsync(query.Offset, query.Limit);
    }
}
