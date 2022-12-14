using ECommerce_RetroGaming.Areas.Admin.Models;
using ECommerce_RetroGaming.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_RetroGaming.Areas.Identity.Data;

public class ECommerceDbContext: IdentityDbContext<ApplicationUser>
{
  public DbSet<Category> Categories { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<CategoryProduct> CategoryProducts { get; set; }
  public ECommerceDbContext( DbContextOptions<ECommerceDbContext> options )
      : base(options)
  {
  }

  protected override void OnModelCreating( ModelBuilder builder )
  {
    base.OnModelCreating(builder);
    // Customize the ASP.NET Identity model and override the defaults if needed.
    // For example, you can rename the ASP.NET Identity table names and more.
    // Add your customizations after calling base.OnModelCreating(builder);
  }
}
