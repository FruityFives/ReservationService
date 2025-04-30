using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ReservationServiceAPI.Controllers;
using ReservationServiceAPI.Controllers.Models;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _service;

    public ReservationController(IReservationService service)
    {
        _service = service;
    }

    // POST /reservations
    [HttpPost]
    public async Task<IActionResult> CreateReservation([FromBody] Reservation reservation)
    {
        if (reservation == null)
            return BadRequest("Reservation cannot be null.");

        var created = await _service.CreateReservationAsync(reservation);
        return CreatedAtAction(nameof(GetReservation), new { id = created.Id }, created);
    }

    // GET /reservations/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetReservation(int id)
    {
        var reservation = await _service.GetReservationByIdAsync(id);
        if (reservation == null)
            return NotFound($"No reservation found with ID {id}");

        return Ok(reservation);
    }

    // DELETE /reservations/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReservation(int id)
    {
        var success = await _service.DeleteReservationAsync(id);
        if (!success)
            return NotFound($"No reservation found with ID {id}");

        return NoContent();
    }
}