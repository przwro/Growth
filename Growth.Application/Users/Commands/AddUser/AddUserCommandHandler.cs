using Growth.Application.Common.Interfaces;
using Growth.Domain.Entities;
using MediatR;

namespace Growth.Application.Users.Commands.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Unit>
{
    private readonly IApplicationDbContext _context;

    public AddUserCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User { FirstName = request.FirstName, LastName = request.LastName, 
                              Address = new Address { Street = request.Address.Street, UserId = request.Id} 
                            };

        _context.Users.Add(user);
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

