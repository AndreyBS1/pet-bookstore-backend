using PetBookstore.Domain.AggregatesModel.BookAggregate;
using PetBookstore.Application.Common.Queries;

namespace PetBookstore.Application.Books.Queries;

public class GetBookRangeQuery : GetEntityRangeQuery<List<Book>> { }
