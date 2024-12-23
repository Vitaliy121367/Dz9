namespace Dz9._4
{
    public class Numbers
    {
        private int[] num;
        public Numbers(int len)
        {
            num = new int[len];
            for (int i = 0; i < len; i++)
            {
                num[i] = new Random().Next(1, 20);
            }
        }
        public void PrintNumbers()
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                Console.Write($"{num[i]} ");
            }
        }
        public void PrintNumbersFunc(Func<int, int> condition)
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                Console.Write($"{condition(num[i])} ");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            Numbers numbers = new Numbers(10);
            numbers.PrintNumbers();

            Console.WriteLine();
            Func<int, int> editInt = n => n*n;
            numbers.PrintNumbersFunc(editInt);

            Console.WriteLine();
            editInt = n => n * 2;
            numbers.PrintNumbersFunc(editInt);

            Console.WriteLine();
            editInt = n => n - 5;
            numbers.PrintNumbersFunc(editInt);
        }
    }
}
