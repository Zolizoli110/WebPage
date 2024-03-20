using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Models;
using WebApplication4.Models;

namespace WebApplication4.DataBase;

using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<News> News { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
    }
}