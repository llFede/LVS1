using LVS1.wpf.Models;
using Microsoft.EntityFrameworkCore;

namespace LVS1.wpf.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; }
}