using CartApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CartApi.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Relationships
        modelBuilder.Entity<Cart>()
            .HasOne<User>()
            .WithOne()
            .HasForeignKey<Cart>(c => c.UserId);

        modelBuilder.Entity<CartItem>()
            .HasOne(c => c.Cart)
            .WithMany(ci => ci.CartItems)
            .HasForeignKey(ci => ci.CartId);

        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.Item)
            .WithMany()
            .HasForeignKey(ci => ci.ItemId);
    }
}