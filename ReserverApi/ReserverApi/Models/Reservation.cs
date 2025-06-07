namespace ReserverApi.Models;

public class Reservation
{
    public int Id { get; set; }
    public bool Cancelled { get; set; }
    public Seat Seat { get; set; }
}
