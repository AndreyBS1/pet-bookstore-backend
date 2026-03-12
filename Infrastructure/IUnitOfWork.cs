using PetBookstore.Infrastructure.Repositories;

namespace PetBookstore.Infrastructure;

public interface IUnitOfWork
{
  public BookRepository Books { get; }
  public GenreRepository Genres { get; }

  public Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
