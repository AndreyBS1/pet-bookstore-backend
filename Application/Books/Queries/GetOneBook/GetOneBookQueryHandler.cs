using MediatR;
using PetBookstore.Infrastructure;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Application.Common.Exceptions;

namespace PetBookstore.Application.Books.Queries;

public class GetOneBookQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetOneBookQuery, Book>
{
  public async Task<Book> Handle(GetOneBookQuery query, CancellationToken cancellationToken)
  {
    var book = await unitOfWork.Books.GetByIDAsync(query.ID);

    if (book is null)
      throw new NotFoundException($"Book with ID {query.ID} not found");

    return book;
  }
}
