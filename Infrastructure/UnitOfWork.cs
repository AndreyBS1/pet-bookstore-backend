using PetBookstore.Infrastructure.Contexts;
using PetBookstore.Infrastructure.Repositories;

namespace PetBookstore.Infrastructure;

public class UnitOfWork(GlobalDbContext context) : IUnitOfWork
{
  private readonly UserRepository _users = new(context);
  private readonly BookRepository _books = new(context);
  private readonly GenreRepository _genres = new(context);

  public UserRepository Users => _users;
  public BookRepository Books => _books;
  public GenreRepository Genres => _genres;

  public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
  {
    await context.SaveChangesAsync(cancellationToken);
  }
}
