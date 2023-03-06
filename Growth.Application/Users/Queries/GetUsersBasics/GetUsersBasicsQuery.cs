using MediatR;

namespace Growth.Application.Users.Queries.GetUsersBasics;

public class GetUsersBasicsQuery : IRequest<IEnumerable<UserBasicsDto>>
{
}
