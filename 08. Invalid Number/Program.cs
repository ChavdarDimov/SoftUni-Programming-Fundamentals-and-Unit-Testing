namespace _08._Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());

            if (numberInput < 100 || numberInput > 200)
            {
                if (numberInput != 0)
                {
                    Console.WriteLine("invalid");
                }

            }
        }
    }
}