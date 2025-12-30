using MediatR;

namespace PetBookstore.Application.Queries;

public abstract class GetRangeQuery<TEntity> : IRequest<TEntity>
{
    public required int Offset { get; init; }
    public required int Limit { get; init; }
}
