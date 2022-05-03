namespace RentACar.Services
{
    public class BrazilTaxService
    {
        public double Tax(double amount) => amount <= 100.0 ? amount * 0.2 : amount * 0.15;
    }
}