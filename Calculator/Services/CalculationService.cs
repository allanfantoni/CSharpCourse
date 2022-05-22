namespace Calculator.Services
{
    public class CalculationService
    {
        public static double Max(double x, double y) => (x > y) ? x : y;

        public static double Sum(double x, double y) => x + y;

        public static double Square(double x) => x * x;
    }
}