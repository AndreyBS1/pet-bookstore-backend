using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.SeedWork;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Infrastructure;

public class GlobalDbContext(DbContextOptions<GlobalDbContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Genre> Genres => Set<Genre>();
}
