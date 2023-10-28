namespace _04._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int estatesCount = int.Parse(Console.ReadLine());

            for (int floors = floorsCount; floors >= 1; floors -= 1)
            {
                for (int estates = 0; estates < estatesCount; estates += 1)
                {
                    if (floors == floorsCount)
                    {
                        Console.Write($"L{floors}{estates} ");
                    }
                    else if (floors % 2 == 0)
                    {
                        Console.Write($"O{floors}{estates} ");
                    }
                    else
                    {
                        Console.Write($"A{floors}{estates} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}