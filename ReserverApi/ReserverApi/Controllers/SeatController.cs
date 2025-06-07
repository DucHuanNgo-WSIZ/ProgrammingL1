using ReserverApi.DataAccess;
using ReserverApi.Models;
using ReserverApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ReserverApi.Controllers;

[Route("Reservation")]
[ApiController]
public class SeatController(SeatReservationDbContext dbContext) : ControllerBase
{
    [HttpGet]
    public IActionResult MyReservations() 
        => Ok(dbContext.Reservations.ToList());

    [HttpPost]
    public IActionResult NewReservation(NewReservationDto newReservation)
    {
        var reservation = new Reservation
        {
            Seat = dbContext.Seats.First(x => x.Id == newReservation.SeatId)
        };

        dbContext.Reservations.Add(reservation);
        dbContext.SaveChanges();
        return Ok();
    }

    [HttpDelete]
    [Route("{reservationId}")]
    public IActionResult DeleteReservation(int reservationId)
    {
        var reservationToDelete =
            dbContext.Reservations.First(x => x.Id == reservationId);

        dbContext.Reservations.Remove(reservationToDelete);
        dbContext.SaveChanges();
        return Ok();
    }
}
