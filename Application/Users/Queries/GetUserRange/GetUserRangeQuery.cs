using PetBookstore.Domain.AggregatesModel.UserAggregate;
using PetBookstore.Application.Common.Queries;

namespace PetBookstore.Application.Users.Queries;

public class GetUserRangeQuery : GetEntityRangeQuery<List<User>> { }
