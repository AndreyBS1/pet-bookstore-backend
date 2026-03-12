using PetBookstore.Domain.SeedWork;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Domain.AggregatesModel.BookAggregate;

public class Book : Entity, IAggregateRoot
{
  public string Title { get; set; } = string.Empty;
  public string Author { get; set; } = string.Empty;
  public decimal Price { get; set; }
  public int Quantity { get; set; }

  public List<Genre> Genres { get; init; } = [];
}
