namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum = sum + num;

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            int sumNoMaxNumber = sum - maxNumber;

            if (maxNumber == sumNoMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(maxNumber - sumNoMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}