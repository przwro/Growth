using System.ComponentModel;

namespace Growth.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    [DisplayName("Ulica")]
    public string Street { get; set; } 
    public int UserId { get; set; }
    public User User { get; set; }
}
