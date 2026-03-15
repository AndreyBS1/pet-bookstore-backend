using Microsoft.EntityFrameworkCore;
using PetBookstore.Domain.AggregatesModel.UserAggregate;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Infrastructure.Contexts;

public class GlobalDbContext(DbContextOptions<GlobalDbContext> options) : DbContext(options)
{
  public DbSet<User> Users => Set<User>();
  public DbSet<Book> Books => Set<Book>();
  public DbSet<Genre> Genres => Set<Genre>();
}
