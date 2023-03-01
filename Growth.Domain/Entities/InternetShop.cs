namespace Growth.Domain.Entities;

public class InternetShop
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public ICollection<UserInternetShop> UserInternetShop { get; set; } = new HashSet<UserInternetShop>();
}
