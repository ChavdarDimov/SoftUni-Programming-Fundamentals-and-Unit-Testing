namespace _10._Valid_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool isValidTriangle = true;

            if (a + b <= c)
            {
                isValidTriangle = false;
            }
            else if (a + c <= b)
            {
                isValidTriangle = false;
            }
            else if (b + c <= a)
            {
                isValidTriangle = false;
            }

            if (isValidTriangle)
            {
                Console.WriteLine("Valid Triangle");
            }
            else if (!isValidTriangle)
            {
                Console.WriteLine("Invalid Triangle");
            }
        }
    }
}