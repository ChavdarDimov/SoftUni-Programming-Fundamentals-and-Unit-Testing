namespace _09._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aptWidth = int.Parse(Console.ReadLine());
            int aptLegth = int.Parse(Console.ReadLine());
            int aptHeight = int.Parse(Console.ReadLine());

            int aptTotalSize = aptWidth * aptLegth * aptHeight; // Note: One box has exact dimensions: 1m x 1m x 1m

            while (aptTotalSize >= 0)
            {
                String input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                aptTotalSize = aptTotalSize - int.Parse(input);
            }

            if (aptTotalSize >= 0)
            {
                Console.WriteLine($"{aptTotalSize} Cubic meters left.");
            } 
            else
            {
                Console.WriteLine($"No more free space! You need {-aptTotalSize} Cubic meters more.");
            }
        }
    }
}