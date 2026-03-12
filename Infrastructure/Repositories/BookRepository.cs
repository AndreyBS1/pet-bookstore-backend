using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Infrastructure.Contexts;

namespace PetBookstore.Infrastructure.Repositories;

public class BookRepository : Repository<Book>, IBookRepository
{
  public BookRepository(GlobalDbContext context) : base(context)
  {
    EntitySet = context.Books;
  }

  public Task<List<Book>> GetRangeAsync(int offset, int limit)
  {
    return EntitySet.Skip(offset).Take(limit).ToListAsync();
  }
}
