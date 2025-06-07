using ReserverApi.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ReserverApi;

public class TestController
{
    private readonly SeatReservationDbContext _dbContext;

    public TestController(SeatReservationDbContext dbContext) => _dbContext = dbContext;

    [Route("/")]
    [AllowAnonymous]
    public object Test() => _dbContext.Reservations.ToList();
}
