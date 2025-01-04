using Microsoft.EntityFrameworkCore;
using PEESFPIV.Frontend.Models;

namespace PEESFPIV.Frontend.Databases;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<MenuBar> MenuBars { get; set; }
}