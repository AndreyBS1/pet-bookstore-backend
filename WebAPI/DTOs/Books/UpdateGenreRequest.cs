namespace PetBookstore.WebAPI.DTOs.Books;

public class UpdateBookRequest
{
  public required string Title { get; init; } = string.Empty;
  public required string Author { get; init; } = string.Empty;
  public required decimal Price { get; init; }
  public required int Quantity { get; init; }
}
