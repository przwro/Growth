namespace Growth.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    public ICollection<UserInternetShop> UserInternetShop { get; set; } = new HashSet<UserInternetShop>();
}
