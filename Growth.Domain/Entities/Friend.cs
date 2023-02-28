namespace Growth.Domain.Entities;

public class Friend
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }    
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
}
