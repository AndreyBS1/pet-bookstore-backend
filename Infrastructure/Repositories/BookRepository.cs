using Microsoft.EntityFrameworkCore;
using PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Experiment.Infrastructure.Repositories;

public class BookRepository(GlobalDbContext context) : Repository<Book>(context), IBookRepository
{
    public Task<List<Book>> GetRangeAsync(int offset, int limit)
    {
        return EntitySet.Skip(offset).Take(limit).ToListAsync();
    }
}
