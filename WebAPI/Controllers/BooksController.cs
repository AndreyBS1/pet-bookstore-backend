using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Application.Books.Commands;
using PetBookstore.Application.Books.Queries;
using PetBookstore.WebAPI.DTOs.Books;
using PetBookstore.WebAPI.DTOs.Common;

namespace PetBookstore.WebAPI.Controllers;

public class BooksController(IMediator mediator) : Controller
{
  [HttpPost]
  public async Task<Response<Book>> CreateBook([FromBody] CreateBookRequest request)
  {
    var command = new CreateBookCommand
    {
      Title = request.Title,
      Author = request.Author,
      Price = request.Price,
      Quantity = request.Quantity,
    };
    return FormatResponse(await mediator.Send(command));
  }

  [HttpGet]
  public async Task<Response<List<Book>>> GetAllBooks([FromQuery] GetRangeRequest request)
  {
    var query = new GetBookRangeQuery
    {
      Offset = request.Offset,
      Limit = request.Limit
    };
    return FormatResponse(await mediator.Send(query));
  }

  [HttpGet("{id:int}")]
  public async Task<Response<Book>> GetOneBook([FromRoute] int ID)
  {
    var query = new GetOneBookQuery
    {
      ID = ID
    };
    return FormatResponse(await mediator.Send(query));
  }

  [HttpPut("{id:int}")]
  public async Task<Response<Book>> UpdateBook([FromRoute] int ID, [FromBody] UpdateBookRequest request)
  {
    var query = new UpdateBookCommand
    {
      ID = ID,
      Title = request.Title,
      Author = request.Author,
      Price = request.Price,
      Quantity = request.Quantity,
    };
    return FormatResponse(await mediator.Send(query));
  }

  [HttpDelete("{id:int}")]
  public async Task<Response<string>> DeleteBook([FromRoute] int ID)
  {
    var query = new DeleteBookCommand
    {
      ID = ID,
    };
    await mediator.Send(query);
    return FormatResponse(ID.ToString());
  }
}
