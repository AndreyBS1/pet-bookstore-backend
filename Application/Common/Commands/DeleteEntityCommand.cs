using MediatR;

namespace PetBookstore.Application.Common.Commands;

public class DeleteEntityCommand : IRequest
{
  public required int ID { get; init; }
}
