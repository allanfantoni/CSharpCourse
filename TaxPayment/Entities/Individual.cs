namespace TaxPayment.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxPaid = AnualIncome < 20000.0 ? AnualIncome * 0.15 : AnualIncome * 0.25;

            if (HealthExpenditures != 0)
            {
                taxPaid -= HealthExpenditures * 0.5;
            }

            return taxPaid;
        }
    }
}
