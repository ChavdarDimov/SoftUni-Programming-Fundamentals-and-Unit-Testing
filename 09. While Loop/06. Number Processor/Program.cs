namespace _06._Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            String command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Inc")
                {
                    input++;
                    command = Console.ReadLine();
                }
                else if (command == "Dec")
                {
                    input--;
                    command = Console.ReadLine();
                }
            }

            Console.WriteLine(input);
        }
    }
}