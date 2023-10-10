namespace _05._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int row = 1; row < size; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{counter} ");
                    counter++;

                    if (counter > size)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (counter > size)
                {
                    break;
                }
            } 
        }
    }
}