using RentACar.Entities;

namespace RentACar.Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = duration.TotalHours <= 12.0 ? PricePerHour * Math.Ceiling(duration.TotalHours) : PricePerDay * Math.Ceiling(duration.TotalDays);
            double tax = _brazilTaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}