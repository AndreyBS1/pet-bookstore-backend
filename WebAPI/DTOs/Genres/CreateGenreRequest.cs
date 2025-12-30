namespace PetBookstore.Experiment.WebAPI.DTOs.Genres;

public class CreateGenreRequest
{
    public required string Label { get; init; } = string.Empty;
}
