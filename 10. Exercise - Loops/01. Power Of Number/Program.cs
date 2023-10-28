namespace _01._Power_Of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * numberInput;
            }

            Console.WriteLine(result);
        }
    }
}