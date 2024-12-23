using static System.Net.Mime.MediaTypeNames;

namespace Dz9._3
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] text =
            {
                "Field",
                "Wind",
                "Castle",
                "Forester",
                "Star",
                "Fog",
                "Violin",
                "Cloud",
                "Ladder",
                "Sparrow"
            };
            for (int i = 0; i < text.GetLength(0); i++)
            {
                Console.Write($"{text[i]} ");
            }
            Action<string> editString = n => Console.Write(n.ToUpper());

            Console.WriteLine();
            for (int i = 0; i < text.GetLength(0); i++)
            {
                editString(text[i]);
                Console.Write(" ");
            }

            editString = n => Console.Write(n.Length);
            Console.WriteLine();
            for (int i = 0; i < text.GetLength(0); i++)
            {
                editString(text[i]);
                Console.Write(" ");
            }

            editString = n => Console.Write($"*{n}* ");
            Console.WriteLine();
            for (int i = 0; i < text.GetLength(0); i++)
            {
                editString(text[i]);
            }
        }
    }
}
