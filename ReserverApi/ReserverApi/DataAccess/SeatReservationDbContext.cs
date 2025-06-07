using Microsoft.EntityFrameworkCore;
using ReserverApi.Models;

namespace ReserverApi.DataAccess;


public class SeatReservationDbContext : DbContext
{
    public SeatReservationDbContext(DbContextOptions<SeatReservationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Seat>().HasKey(p => p.Id);

        modelBuilder.Entity<Reservation>().HasKey(p => p.Id);
    }

    public DbSet<Seat> Seats { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}
