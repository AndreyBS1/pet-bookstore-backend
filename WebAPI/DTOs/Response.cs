namespace PetBookstore.Experiment.WebAPI.DTOs
{
    public class Response
    {
        public required int Status { get; init; }
        public required object? Data { get; init; }
        public string[] Errors { get; init; } = Array.Empty<string>();
    }

    public class Response<TData>
    {
        public required int Status { get; init; }
        public required TData? Data { get; init; }
        public string[] Errors { get; init; } = Array.Empty<string>();
    }
}
