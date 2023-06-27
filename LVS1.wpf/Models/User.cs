namespace LVS1.wpf.Models;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}