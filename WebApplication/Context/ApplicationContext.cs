using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication.Authentication;
using WebApplication.Models;

namespace WebApplication.Context
{
  public class ApplicationContext : IdentityDbContext<ApplicationUser>
  {
    private DbSet<WalletModel> WalletModels { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder) 
    {
      base.OnModelCreating(builder);
      builder.Entity<WalletModel>()
        .HasKey(x => x.Id);
    } 
  }
}