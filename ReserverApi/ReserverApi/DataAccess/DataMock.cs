using ReserverApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ReserverApi.DataAccess;

public class DataMock
{
    public static SeatReservationDbContext GetContextWithData()
    {
        var options = new DbContextOptionsBuilder<SeatReservationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var context = new SeatReservationDbContext(options);

        var seat1 = new Seat { Id = 1, Location = "front", Class = "first", Price = 10.0m };
        var seat2 = new Seat { Id = 2, Location = "front", Class = "first", Price = 10.0m };
        var seat3 = new Seat { Id = 3, Location = "front", Class = "second", Price = 8.0m };
        var seat4 = new Seat { Id = 4, Location = "front", Class = "second", Price = 8.0m };
        var seat5 = new Seat { Id = 5, Location = "front", Class = "second", Price = 8.0m };
        var seat6 = new Seat { Id = 6, Location = "back", Class = "first", Price = 6.0m };
        var seat7 = new Seat { Id = 7, Location = "back", Class = "first", Price = 6.0m };
        var seat8 = new Seat { Id = 8, Location = "back", Class = "second", Price = 5.0m };
        var seat9 = new Seat { Id = 9, Location = "back", Class = "second", Price = 5.0m };
        var seat10 = new Seat { Id = 10, Location = "back", Class = "second", Price = 5.0m };

        var reservation1 = new Reservation
        {
            Id = 1,
            Cancelled = false,
            Seat = seat1
        };

        context.Seats.Add(seat1);
        context.Seats.Add(seat2);
        context.Seats.Add(seat3);
        context.Seats.Add(seat4);
        context.Seats.Add(seat5);
        context.Seats.Add(seat6);
        context.Seats.Add(seat7);
        context.Seats.Add(seat8);
        context.Seats.Add(seat9);
        context.Seats.Add(seat10);

        context.Reservations.Add(reservation1);

        context.SaveChanges();
        return context;
    }
}
