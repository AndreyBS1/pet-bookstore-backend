using MediatR;
using PetBookstore.Experiment.Domain.AggregatesModel.GenreAggregate;

namespace PetBookstore.Experiment.Application.Genres.Queries;

public class GetAllGenresQuery : IRequest<List<Genre>> { }
