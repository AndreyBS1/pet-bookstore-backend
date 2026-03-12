using Microsoft.AspNetCore.Mvc;
using PetBookstore.WebAPI.DTOs.Common;

namespace PetBookstore.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Controller : ControllerBase
{
  protected Response<TData> FormatResponse<TData>(TData data, int status = 200)
  {
    return new Response<TData>
    {
      Status = status,
      Data = data,
    };
  }

  protected Response FormatResponse(int status = 200)
  {
    return new Response
    {
      Status = status,
      Data = null,
    };
  }
}
