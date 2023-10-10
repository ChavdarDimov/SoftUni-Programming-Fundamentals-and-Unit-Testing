namespace _04._Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            String operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = N1 + N2;
                Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");
            }
            else if (operation == "-")
            {
                result = N1 - N2;
                Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");
            }
            else if (operation == "*")
            {
                result = N1 * N2;
                Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");
            }
            else if (operation == "/")
            {
                result = N1 / N2;
                Console.WriteLine($"{N1} {operation} {N2} = {result:f2}");
            }
        }
    }
}