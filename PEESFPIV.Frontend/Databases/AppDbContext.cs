using Microsoft.EntityFrameworkCore;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Utils.Implements;
using PEESFPIV.Frontend.Utils.Interfaces;

namespace PEESFPIV.Frontend.Databases;

public class AppDbContext : DbContext
{
    private readonly IHashString _hashString;
    public AppDbContext(DbContextOptions<AppDbContext> options, IHashString hashString) : base(options)
    {
        _hashString = hashString;
    }

    // public DbSet<MenuBar> MenuBars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
        .ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}