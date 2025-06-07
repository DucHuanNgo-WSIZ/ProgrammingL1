using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReserverApi.Controllers;

[Route("[controller]")]
[ApiController]
public class SeatController : ControllerBase
{
    [HttpGet]
    public IEnumerable<object> GetAll() => [
        new { Id = 1, Location = "front", Class = "first", Price = 10.0 },
        new { Id = 2, Location = "front", Class = "first", Price = 10.0 },
        new { Id = 3, Location = "front", Class = "second", Price = 8.0 },
        new { Id = 4, Location = "front", Class = "second", Price = 8.0 },
        new { Id = 5, Location = "front", Class = "second", Price = 8.0 },
        new { Id = 6, Location = "back", Class = "first", Price = 6.0 },
        new { Id = 7, Location = "back", Class = "first", Price = 6.0 },
        new { Id = 8, Location = "back", Class = "second", Price = 5.0 },
        new { Id = 9, Location = "back", Class = "second", Price = 5.0 },
        new { Id = 10, Location = "back", Class = "second", Price = 5.0 }
    ];
}
