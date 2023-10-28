namespace _03._Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int startNumber = 1;

            while (startNumber <= maxNumber)
            {
                Console.WriteLine(startNumber);
                startNumber = (startNumber * 2) + 1;
            }
        }
    }
}