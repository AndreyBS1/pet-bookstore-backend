using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Experiment.Application.Commands;
using PetBookstore.Experiment.Application.Queries;
using PetBookstore.Experiment.WebAPI.DTOs;

namespace PetBookstore.Experiment.WebAPI.Controllers
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
