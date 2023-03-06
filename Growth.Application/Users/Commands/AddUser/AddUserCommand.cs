using Growth.Domain.Entities;
using MediatR;
using System.ComponentModel;

namespace Growth.Application.Users.Commands.AddUser;

public class AddUserCommand : IRequest<Unit>
{
	public int Id { get; set; }
    [DisplayName("Imię")]
    public string FirstName { get; set; }
	[DisplayName("Nazwisko")]
	public string LastName { get; set; }
    public Address Address { get; set; }
    public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    public ICollection<UserInternetShop> UserInternetShop { get; set; } = new HashSet<UserInternetShop>();
}

