namespace _02._Equal_Sum_of_Even_and_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                String currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum = evenSum + currentDigit;
                    }

                    else
                    {
                        oddSum = oddSum + currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}