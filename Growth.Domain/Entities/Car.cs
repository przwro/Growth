namespace Growth.Domain.Entities;

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
