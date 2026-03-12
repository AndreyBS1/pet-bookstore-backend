using MediatR;

namespace PetBookstore.Application.Common.Queries;

public abstract class GetEntityRangeQuery<TEntity> : IRequest<TEntity>
{
  public required int Offset { get; init; }
  public required int Limit { get; init; }
}
