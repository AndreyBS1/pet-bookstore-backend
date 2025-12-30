using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Application.Commands;
using PetBookstore.Application.Queries;
using PetBookstore.WebAPI.DTOs;

namespace PetBookstore.WebAPI.Controllers
{
    public class BookController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<Response<Book>> Books([FromBody] CreateBookRequest request)
        {
            var command = new CreateBookCommand
            {
                Title = request.Title,
                Author = request.Author,
                Price = request.Price,
                Quantity = request.Quantity,
            };
            return FormatResponse(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<Response<List<Book>>> Books([FromQuery] GetRangeRequest request)
        {
            var query = new GetBookRangeQuery
            {
                Offset = request.Offset,
                Limit = request.Limit
            };
            return FormatResponse(await _mediator.Send(query));
        }
    }
}
