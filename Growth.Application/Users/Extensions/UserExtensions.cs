using Growth.Application.Users.Queries.GetUsersBasics;
using Growth.Domain.Entities;

namespace Growth.Application.Users.Extensions;

public static class UserExtensions
{
    public static UserBasicsDto ToDto(this User user)
    {
        if (user == null)
            return null;

        return new UserBasicsDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
        };
    }
}
