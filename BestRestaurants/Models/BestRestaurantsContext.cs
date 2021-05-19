using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisine { get; set; }
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}