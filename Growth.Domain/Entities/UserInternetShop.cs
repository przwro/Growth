namespace Growth.Domain.Entities;

public class UserInternetShop
{
    public int UserId { get; set; }
    public User User{ get; set; }
    public int InternetShopId { get; set; }
    public InternetShop InternetShop { get; set; }
}
