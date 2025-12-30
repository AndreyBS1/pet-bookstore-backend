using Microsoft.EntityFrameworkCore;
using PetBookstore.Experiment.Domain.SeedWork;
using PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Infrastructure;

public class GlobalDbContext(DbContextOptions<GlobalDbContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Genre> Genres => Set<Genre>();
}
