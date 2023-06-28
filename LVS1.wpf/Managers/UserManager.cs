using LVS1.wpf.Data;
using LVS1.wpf.Models;
using LVS1.wpf.Models.Validators;
using Microsoft.EntityFrameworkCore;

namespace LVS1.wpf.Managers;

public class UserManager
{
    private readonly ApplicationDbContext _context;

    public UserManager(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Register(RegisterUserModel user)
    {
        if (user.HasErrors) return;

        await _context.Users.AddAsync(new User {Email = user.Email, FirstName = user.FirstName, Password = user.Password.ToString(), Surname = user.Surname});
        await _context.SaveChangesAsync();
    }

    public async Task<AuthorizeResult> Authorize(string email, string password)
    {
        var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == email && user.Password == password);
        return
            user is null
                ? new AuthorizeResult(false)
                : new AuthorizeResult(true, user);
    }
}