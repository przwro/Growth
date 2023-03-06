using FluentValidation;
using Growth.Application.Common.Extensions;

namespace Growth.Application.Users.Commands.AddUser;

public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
{
	public AddUserCommandValidator()
	{
		RuleFor(x => x.FirstName).NotEmpty().MinimumLength(4).WithName(ModelExtensions.GetDisplayName<AddUserCommand>(p => p.FirstName));
		RuleFor(x => x.LastName).NotEmpty().WithName(ModelExtensions.GetDisplayName<AddUserCommand>(p => p.LastName));
	}
}

