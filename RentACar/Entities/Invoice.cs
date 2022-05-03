namespace RentACar.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString() => $"Basic payment: {BasicPayment:F2} \nTax: {Tax:F2} \nTotal payment: {TotalPayment:F2}";
    }
}