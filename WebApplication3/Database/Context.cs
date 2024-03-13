using WebApplication4.Models;

namespace WebApplication4.DataBase;

using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Reservation> Reservations { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=postgres");
    }
}