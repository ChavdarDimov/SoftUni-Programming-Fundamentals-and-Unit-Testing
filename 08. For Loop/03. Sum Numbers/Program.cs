namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            for (int numbers = 1; numbers <= n; numbers += 1)
            {
                double input = double.Parse(Console.ReadLine());

                sum = sum + input;
            }

            Console.WriteLine(sum);
        }
    }
}