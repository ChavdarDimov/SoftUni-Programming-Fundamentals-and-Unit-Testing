int n = int.Parse(Console.ReadLine());

// magic number = 100 - 999 (3 digit)

for (int number1 = 1; number1 <= 9; number1++)
{
    for (int number2 = 0; number2 <= 9; number2++)
    {
        for (int number3 = 0; number3 <= 9; number3++)
        {
            if (number1 * number2 * number3 == n)
            {
                Console.Write($"{number1}{number2}{number3} ");
            }
        }
    }
}