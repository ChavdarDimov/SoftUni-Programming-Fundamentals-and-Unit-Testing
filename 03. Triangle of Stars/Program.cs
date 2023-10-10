using System.Data;

namespace _03._Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= size; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}