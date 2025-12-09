using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.SeedWork;
using PetBookstore.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Infrastructure;

public class GlobalDbContext(DbContextOptions<GlobalDbContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Book> Books => Set<Book>();

    /** <summary>
    Asynchronously applies any pending migrations for the context to the database.
    Will create the database if it does not already exist.
    Intended to use with DI to operate scoped service.
    See <c>Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade.MigrateAsync</c>
    for more information and examples.
    </summary>
    <returns>
    A task that represents the asynchronous migration operation.
    </returns>
    <exception cref="OperationCanceledException"></exception> */
    public static Task MigrateAsync(GlobalDbContext context)
    {
        return context.Database.MigrateAsync();
    }
}
