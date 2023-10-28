namespace _07._Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            for (int i = start; i <= end; i += 1)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}