using Growth.Application.Common.Interfaces;
using Growth.Application.Users.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Growth.Application.Users.Queries.GetUsersBasics;

public class GetUsersBasicsQueryHandler : IRequestHandler<GetUsersBasicsQuery, IEnumerable<UserBasicsDto>>
{
    private readonly IApplicationDbContext _context;

    public GetUsersBasicsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserBasicsDto>> Handle(GetUsersBasicsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users
            .AsNoTracking()
            .OrderByDescending(x => x.Id)
            .Select(x => x.ToDto())
            .ToListAsync();
    }
}
