namespace ReservationServiceAPI.Controllers.Models;

public class Reservation
{
    public int Id { get; set; }
    public string RoomNumber { get; set; }
    public string Description { get; set; }
    public bool IsBooked { get; set; }
    public DateTime Date { get; set; }
    public int CustomerId { get; set; }
}