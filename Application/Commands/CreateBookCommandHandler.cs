using MediatR;
using PetBookstore.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Application.Commands;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Book>
{
    private readonly IBookRepository _bookRepository;

    public CreateBookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var book = new Book
        {
            Title = request.Title,
            Author = request.Author,
            Price = request.Price,
            Quantity = request.Quantity
        };

        _bookRepository.Add(book);

        await _bookRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return book;
    }
}
