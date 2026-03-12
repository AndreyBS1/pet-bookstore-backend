namespace PetBookstore.WebAPI.DTOs.Genres;

public class UpdateGenreRequest
{
  public required string Label { get; init; } = string.Empty;
}
