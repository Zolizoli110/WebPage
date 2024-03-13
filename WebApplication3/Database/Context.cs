using WebApplication4.Models;

namespace WebApplication4.DataBase;

using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public virtual DbSet<UserModel> Users { get; set; }
    public virtual DbSet<ReservationModel> Reservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
    }
}