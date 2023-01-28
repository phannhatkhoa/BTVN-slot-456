namespace Rhombus
{
    internal class Program
    {
        static void RhombusOfStars()
        {
            Console.WriteLine("Enter number of star: ");
            int size = int.Parse(Console.ReadLine());
            for (int star = 1; star <= size; star++)
                PrintRow(size, star);
            for (int star = size - 1; star >= 1; star--)
                PrintRow(size, star);

        }
        static void PrintRow(int size, int star)
        {
            for (int i = 0; i < size - star; i++)
                Console.Write(" ");
            for (int col = 1; col < star; col++)
                Console.Write("* ");
            Console.WriteLine("*");
        }

        static void Main(string[] args)
        {
            RhombusOfStars();
        }
    }
}