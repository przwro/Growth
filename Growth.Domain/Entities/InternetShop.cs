namespace Growth.Domain.Entities;

public class InternetShop
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public ICollection<UserInternetShop> UserInternetShops { get; set; } = new HashSet<UserInternetShop>();
}
