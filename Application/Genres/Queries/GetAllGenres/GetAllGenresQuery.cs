using MediatR;
using PetBookstore.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Application.Genres.Queries;

public class GetAllGenresQuery : IRequest<List<Genre>> { }
