namespace _08._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int cakeTotalSize = cakeLength * cakeWidth; // number of pieces as well, since one piece is 1x1

            while (cakeTotalSize >= 0)
            {
                String input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                cakeTotalSize = cakeTotalSize - int.Parse(input);
            }

            if (cakeTotalSize <= 0)
            {
                Console.WriteLine($"No more cake left! You need {-cakeTotalSize} pieces more.");
            } 
            else
            {
                Console.WriteLine($"{cakeTotalSize} pieces are left.");
            }
        }
    }
}