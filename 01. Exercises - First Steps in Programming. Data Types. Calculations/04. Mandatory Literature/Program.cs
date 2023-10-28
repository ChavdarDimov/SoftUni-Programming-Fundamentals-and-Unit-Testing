namespace _04._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesReadInHour = int.Parse(Console.ReadLine());
            int numberOfDaysAvailable = int.Parse(Console.ReadLine());

            int totalReadingTimeOfBook = numberOfPages / pagesReadInHour;
            int requiredHoursPerDay = totalReadingTimeOfBook / numberOfDaysAvailable;

            Console.WriteLine(requiredHoursPerDay);

        }
    }
}