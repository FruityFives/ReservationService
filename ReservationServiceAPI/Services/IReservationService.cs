using ReservationServiceAPI.Controllers.Models;

namespace ReservationServiceAPI.Controllers;

public interface IReservationService
{
    Task<Reservation> CreateReservationAsync(Reservation reservation);
    Task<Reservation> GetReservationByIdAsync(int id);
    Task<bool> DeleteReservationAsync(int id);
}