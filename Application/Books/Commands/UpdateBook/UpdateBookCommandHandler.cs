using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Books.Commands;

public class UpdateBookCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateBookCommand, Book>
{
  public async Task<Book> Handle(UpdateBookCommand command, CancellationToken cancellationToken)
  {
    var book = await unitOfWork.Books.GetByIDAsync(command.ID);

    if (book is null)
      throw new NotFoundException($"Book with ID {command.ID} not found");

    book.Title = command.Title;
    book.Author = command.Author;
    book.Price = command.Price;
    book.Quantity = command.Quantity;

    await unitOfWork.SaveChangesAsync(cancellationToken);

    return book;
  }
}
