using PetBookstore.Infrastructure.Contexts;
using PetBookstore.Infrastructure.Repositories;

namespace PetBookstore.Infrastructure;

public class UnitOfWork(GlobalDbContext context) : IUnitOfWork
{
  private readonly BookRepository _books = new(context);
  private readonly GenreRepository _genres = new(context);

  public BookRepository Books => _books;
  public GenreRepository Genres => _genres;

  public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
  {
    await context.SaveChangesAsync(cancellationToken);
  }
}
