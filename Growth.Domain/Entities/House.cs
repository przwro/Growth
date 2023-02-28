namespace Growth.Domain.Entities;

public class House
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public ICollection<ApplicationUser> Users { get; set; }
}
