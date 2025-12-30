using PetBookstore.Domain.AggregatesModel.BookAggregate;

namespace PetBookstore.Application.Queries;

public class GetBookRangeQuery : GetRangeQuery<List<Book>> { }
