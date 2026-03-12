using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Infrastructure.Contexts;

public class GlobalDbContext(DbContextOptions<GlobalDbContext> options) : DbContext(options)
{
  public DbSet<Book> Books => Set<Book>();
  public DbSet<Genre> Genres => Set<Genre>();
}
