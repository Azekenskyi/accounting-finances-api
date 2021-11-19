using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication.Authentication;

namespace WebApplication.Context
{
  public class ApplicationContext : IdentityDbContext<ApplicationUser>
  {
    private DbSet<Wallet> Wallet { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
      Database.Migrate();
    }
    
    protected override void OnModelCreating(ModelBuilder builder) 
    {
      base.OnModelCreating(builder);
    } 
  }
}