namespace PetBookstore.WebAPI.DTOs.Genres;

public class CreateGenreRequest
{
    public required string Label { get; init; } = string.Empty;
}
