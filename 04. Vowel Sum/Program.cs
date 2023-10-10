namespace _04._Vowel_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int value = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char vowel = char.Parse(Console.ReadLine());

                if (vowel == 'a')
                {
                    value = 1;
                }
                else if (vowel == 'e')
                {
                    value = 2;
                }
                else if (vowel == 'i')
                {
                    value = 3;
                }
                else if (vowel == 'o')
                {
                    value = 4;
                }
                else if (vowel == 'u')
                {
                    value = 5;
                }

                sum = sum + value;
            }

            Console.WriteLine(sum);
        }
    }
}