using ReservationServiceAPI.Controllers.Models;

namespace ReservationServiceAPI.Services;

public interface IReservationRepository
{
    Task<Reservation> AddAsync(Reservation reservation);
    Task<Reservation?> GetByIdAsync(int id);
    Task<bool> DeleteAsync(int id);
}