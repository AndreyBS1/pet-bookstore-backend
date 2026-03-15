using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetBookstore.Domain.AggregatesModel.UserAggregate;
using PetBookstore.Application.Users.Commands;
using PetBookstore.Application.Users.Queries;
using PetBookstore.WebAPI.DTOs.Users;
using PetBookstore.WebAPI.DTOs.Common;

namespace PetBookstore.WebAPI.Controllers;

public class UsersController(IMediator mediator) : Controller
{
  [HttpPost]
  public async Task<Response<User>> CreateUser([FromBody] CreateUserRequest request)
  {
    var command = new CreateUserCommand
    {
      Role = request.Role,
      Name = request.Name,
      Email = request.Email,
      Password = request.Password,
    };
    return FormatResponse(await mediator.Send(command));
  }

  [HttpGet]
  public async Task<Response<List<User>>> GetAllUsers([FromQuery] GetRangeRequest request)
  {
    var query = new GetUserRangeQuery
    {
      Offset = request.Offset,
      Limit = request.Limit
    };
    return FormatResponse(await mediator.Send(query));
  }

  [HttpGet("{id:int}")]
  public async Task<Response<User>> GetOneUser([FromRoute] int ID)
  {
    var query = new GetOneUserQuery
    {
      ID = ID
    };
    return FormatResponse(await mediator.Send(query));
  }

  [HttpPut("{id:int}")]
  public async Task<Response<User>> UpdateUser([FromRoute] int ID, [FromBody] UpdateUserRequest request)
  {
    var query = new UpdateUserCommand
    {
      ID = ID,
      Name = request.Name,
    };
    return FormatResponse(await mediator.Send(query));
  }

  [HttpDelete("{id:int}")]
  public async Task<Response<string>> DeleteUser([FromRoute] int ID)
  {
    var query = new DeleteUserCommand
    {
      ID = ID,
    };
    await mediator.Send(query);
    return FormatResponse(ID.ToString());
  }
}
