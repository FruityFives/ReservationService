using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ReservationServiceAPI.Controllers.Models;
using ReservationServiceAPI.Services;
using System;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace ReservationService.Tests
{
    [TestClass]
    public class ReservationServiceTests
    {
        private Mock<IReservationRepository> _mockRepo;
        private ReservationServiceAPI.Services.ReservationService _service;

        [TestInitialize]
        public void Setup()
        {
            _mockRepo = new Mock<IReservationRepository>();
            _service = new ReservationServiceAPI.Services.ReservationService(_mockRepo.Object);
        }

        [TestMethod]
        public async Task CreateReservation_ShouldReturnReservationWithId()
        {
            // Arrange
            var reservation = new Reservation
            {
                RoomNumber = "101",
                CustomerId = 42,
                Date = DateTime.Today.AddDays(1)
            };

            var expected = new Reservation
            {
                Id = 1,
                RoomNumber = "101",
                CustomerId = 42,
                Date = reservation.Date
            };

            _mockRepo.Setup(repo => repo.AddAsync(It.IsAny<Reservation>())).ReturnsAsync(expected);

            // Act
            var result = await _service.CreateReservationAsync(reservation);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("101", result.RoomNumber);
        }
    }
}