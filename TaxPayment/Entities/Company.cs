namespace TaxPayment.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxPaid = NumberOfEmployees <= 10 ? AnualIncome * 0.16 : AnualIncome * 0.14;

            return taxPaid;
        }
    }
}