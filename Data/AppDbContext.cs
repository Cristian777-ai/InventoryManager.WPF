using Microsoft.EntityFrameworkCore;
using InventoryManager.WPF.Models;

namespace InventoryManager.WPF.Data;

public class AppDbContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=inventory.db");
    }
}
