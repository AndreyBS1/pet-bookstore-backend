namespace PetBookstore.WebAPI.DTOs.Common;

public class GetRangeRequest
{
  public required int Offset { get; init; }
  public required int Limit { get; init; }
}
