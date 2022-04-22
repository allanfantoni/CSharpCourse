using HotelReservation.Entities.Exceptions;

namespace HotelReservation.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            VerifyCheckOutCheckInDates(checkIn, checkOut);

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            VerifyFutureDates(checkIn, checkOut);

            VerifyCheckOutCheckInDates(checkIn, checkOut);

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        private void VerifyCheckOutCheckInDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
                throw new DomainException("Check-out date must be after check-in date.");
        }

        private void VerifyFutureDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
                throw new DomainException("Reservation dates for update must be future dates.");
        }

        public override string ToString()
        {
            return "Room: " + RoomNumber
                + ", check-in: " + CheckIn.ToString("MM/dd/yyyy")
                + ", check-out: " + CheckOut.ToString("MM/dd/yyyy")
                + ", " + Duration() + " nights";
        }
    }
}