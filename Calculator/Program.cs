using Calculator.Services;

namespace Calculator
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}