namespace _02._First_N_Numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int number = 1; number <= n; number++)
            {
                sum = sum + number;

                if (number == 1)
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write("+" + number);
                }
            }

            Console.Write("=" + sum);
        }
    }
}