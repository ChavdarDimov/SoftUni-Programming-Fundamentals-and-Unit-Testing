namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = rows * columns * 12.00;
            }
            else if (type == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else
            {
                income = rows * columns * 5.0;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}