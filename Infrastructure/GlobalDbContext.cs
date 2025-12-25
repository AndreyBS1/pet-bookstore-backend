using Microsoft.EntityFrameworkCore;
using PetBookstore.Experiment.Domain.SeedWork;
using PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Experiment.Infrastructure;

public class GlobalDbContext(DbContextOptions<GlobalDbContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Book> Books => Set<Book>();
}
