namespace Growth.Domain.Entities;

public class ApplicationUser
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime RegisterDateTime { get; set; }
    public bool IsDeleted { get; set; }
    public Address Address { get; set; }
    public ICollection<Friend> Friends { get; set; } = new HashSet<Friend>();
}
