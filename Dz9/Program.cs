namespace Dz9
{
    public delegate double MathDelegate(double param1, double param2);
    public class Program
    {
        public static double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Divide(double x, double y) => y != 0 ? x / y : throw new DivideByZeroException("Error!!!");
        static void Main(string[] args)
        {
            PrintMathOteration(Add, 10, 5);
            PrintMathOteration(Sub, 10, 5);
            PrintMathOteration(Multiply, 10, 5);
            PrintMathOteration(Divide, 10, 5);
        }
        public static void PrintMathOteration(MathDelegate m, double x, double y)
        {
            double result = m(x, y);
            Console.WriteLine($"Result: {result}");
        }
    }
}
