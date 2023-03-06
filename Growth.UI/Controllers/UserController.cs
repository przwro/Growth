using FluentValidation;
using Growth.Application.Users.Commands.AddUser;
using Growth.Application.Users.Queries.GetUsersBasics;
using Growth.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Growth.UI.Controllers;
public class UserController : BaseController
{
	private readonly IValidator<AddUserCommand> _validator;

	public UserController(IValidator<AddUserCommand> validator)
	{
		_validator = validator;
	}

	public async Task<IActionResult> Users()
    {
        return View(await Mediator.Send(new GetUsersBasicsQuery()));
    }

	public async Task<IActionResult> AddUser()
	{
		return View(new AddUserCommand());
	}

    [HttpPost]
	public async Task<IActionResult> AddUser(AddUserCommand command)
    {
		var result = _validator.Validate(command);

		if (!result.IsValid)
		{
			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
			}
			return View(new AddUserCommand());

		}

		await Mediator.Send( new AddUserCommand { FirstName = command.FirstName, LastName = command.LastName,
                Address = new Address { Street = command.Address.Street}
            });

        return RedirectToAction("Users");
    }
}
