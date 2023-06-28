namespace LVS1.wpf.Models;

public class Floor
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public int Number { get; set; }
    public ICollection<Room> Rooms { get; set; } = Array.Empty<Room>();
}