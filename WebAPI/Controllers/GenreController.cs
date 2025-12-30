using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;
using PetBookstore.Application.Genres.Commands;
using PetBookstore.Application.Genres.Queries;
using PetBookstore.WebAPI.DTOs;
using PetBookstore.WebAPI.DTOs.Genres;

namespace PetBookstore.WebAPI.Controllers
{
    public class GenreController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<Response<Genre>> CreateGenre([FromBody] CreateGenreRequest request)
        {
            var command = new CreateGenreCommand
            {
                Label = request.Label
            };
            return FormatResponse(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<Response<List<Genre>>> GetAllGenres()
        {
            var query = new GetAllGenresQuery();
            return FormatResponse(await _mediator.Send(query));
        }

        [HttpGet("{id:int}")]
        public async Task<Response<Genre>> GetOneGenre([FromRoute] int ID)
        {
            var query = new GetOneGenreQuery
            {
                ID = ID
            };
            return FormatResponse(await _mediator.Send(query));
        }

        [HttpPut("{id:int}")]
        public async Task<Response<Genre>> UpdateGenre([FromRoute] int ID, [FromBody] UpdateGenreRequest request)
        {
            var query = new UpdateGenreCommand
            {
                ID = ID,
                Label = request.Label
            };
            return FormatResponse(await _mediator.Send(query));
        }

        [HttpDelete("{id:int}")]
        public async Task<Response<string>> DeleteGenre([FromRoute] int ID)
        {
            var query = new DeleteGenreCommand
            {
                ID = ID,
            };
            await _mediator.Send(query);
            return FormatResponse(ID.ToString());
        }
    }
}
