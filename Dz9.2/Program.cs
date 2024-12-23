namespace Dz9._2
{
    public class Numbers
    {
        private int[] num;
        public Numbers(int len) 
        {
            num = new int[len];
            for (int i = 0; i < len; i++)
            {
                num[i] = new Random().Next(1, 30);
            }
        }
        public void PrintNumbers()
        {
            for (int i = 0; i < num.GetLength(0); i++) 
            {
                Console.Write($"{num[i]} ");
            }
        }
        public void PrintNumbersIf(Func<int, bool> condition)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                if (condition(num[i]))
                {
                    Console.Write($"{num[i]} ");
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Func<int, bool> isEven = n => n % 2 == 0;
            Numbers numbers = new Numbers(10);
            numbers.PrintNumbers();

            Console.WriteLine();
            Func<int, bool> func = n => n % 2 == 0;
            numbers.PrintNumbersIf(func);

            Console.WriteLine();
            func = n => 10 < n;
            numbers.PrintNumbersIf(func);

            Console.WriteLine();
            func = n => n % 3 == 0;
            numbers.PrintNumbersIf(func);
        }
    }
}
