using Microsoft.EntityFrameworkCore;
using PEESFPIV.Frontend.Models;
using PEESFPIV.Frontend.Models.Auth;
using PEESFPIV.Frontend.Utils.Implements;
using PEESFPIV.Frontend.Utils.Interfaces;

namespace PEESFPIV.Frontend.Databases;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<SystemConfig> SystemConfigs { get; set; } = null!;
    public DbSet<Objective> Objectives { get; set; } = null!;
    public DbSet<KeyFocus> KeyFocuses { get; set; } = null!;
    public DbSet<Outcome> Outcomes { get; set; } = null!;
    public DbSet<Partner> Partners { get; set; } = null!;

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;

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