using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Application.Books.Commands;

public class CreateBookCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateBookCommand, Book>
{
  public async Task<Book> Handle(CreateBookCommand command, CancellationToken cancellationToken)
  {
    var book = new Book
    {
      Title = command.Title,
      Author = command.Author,
      Price = command.Price,
      Quantity = command.Quantity
    };

    unitOfWork.Books.Add(book);

    await unitOfWork.SaveChangesAsync(cancellationToken);

    return book;
  }
}
