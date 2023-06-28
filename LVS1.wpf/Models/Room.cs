namespace LVS1.wpf.Models;

public class Room
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public int Number { get; set; }
    public Floor Floor { get; set; }
}