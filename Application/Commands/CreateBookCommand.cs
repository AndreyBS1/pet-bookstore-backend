using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Experiment.Application.Commands;

public class CreateBookCommand : IRequest<Book>
{
    public required string Title { get; init; }
    public required string Author { get; init; }
    public required decimal Price { get; init; }
    public required int Quantity { get; init; }
}
