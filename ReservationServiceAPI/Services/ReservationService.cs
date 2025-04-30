using ReservationServiceAPI.Controllers.Models;
using System.Threading.Tasks;
using ReservationServiceAPI.Controllers;

namespace ReservationServiceAPI.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _repository;

        public ReservationService(IReservationRepository repository)
        {
            _repository = repository;
        }

        public Task<Reservation> CreateReservationAsync(Reservation reservation)
        {
            return _repository.AddAsync(reservation);
        }

        public Task<Reservation?> GetReservationByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<bool> DeleteReservationAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }
    }
}