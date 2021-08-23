using System;
using Xunit;
using Tests;

namespace TestFiles
{
    public class ReservationTest
    {
        [Fact]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var user = new User() { IsAdmin = true };
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(user);

            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_SameUserCancellingReservation()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_AnotherUserCancellingReservation()
        {
            User user1 = new User();
            User user2 = new User();
            var reservation = new Reservation { MadeBy = user1 };

            var result = reservation.CanBeCancelledBy(user2);

            Assert.False(result);
        }
    }
}
