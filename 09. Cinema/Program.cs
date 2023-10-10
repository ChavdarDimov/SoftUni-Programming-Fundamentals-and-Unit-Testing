namespace _09._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            double totalSeats = rows * seats;

            if (movieType == "Premiere")
            {
                totalSeats = totalSeats * 12.00;
                Console.WriteLine($"{totalSeats:f2}");
            }
            else if (movieType == "Normal")
            {
                totalSeats = totalSeats * 7.50;
                Console.WriteLine($"{totalSeats:f2}");
            }
            else if (movieType == "Discount")
            {
                totalSeats = totalSeats * 5.00;
                Console.WriteLine($"{totalSeats:f2}");
            }
        }
    }
}