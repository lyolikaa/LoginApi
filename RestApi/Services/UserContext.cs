using Microsoft.EntityFrameworkCore;
using RestApi.Models;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {

    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(local)\\SQLExpress;Initial Catalog=login;Persist Security Info=True;User ID=sa;Password=***;MultipleActiveResultSets=True;");
    }
    public DbSet<User> Users { get; set; }
}