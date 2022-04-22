using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (MM/dd/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (MM/dd/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (MM/dd/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (MM/dd/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (FormatException ex)
{
    Console.WriteLine("Error in format: " + ex.Message);
}
catch (DomainException ex)
{
    Console.WriteLine("Error in reservation: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error: " + ex.Message);
}