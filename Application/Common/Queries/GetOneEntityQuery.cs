using MediatR;

namespace PetBookstore.Application.Common.Queries;

public class GetOneEntityQuery<TEntity> : IRequest<TEntity>
{
  public required int ID { get; init; }
}
