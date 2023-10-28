using System.Transactions;

namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volumeOfAq = length * width * height;
            double volumeOfAqLitres = volumeOfAq * 0.001;
            double occupiedSpace = percentage / 100;

            double totalLitres = volumeOfAqLitres * (1 - occupiedSpace);
            double roundedNum = Math.Round(totalLitres, 2);

            // Console.WriteLine(roundedNum);
            Console.WriteLine($"{totalLitres:F2}");


        }
    }
}