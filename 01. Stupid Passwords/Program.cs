int n = int.Parse(Console.ReadLine());

for (int number1 = 2; number1 <= n; number1 += 2)
{
    for (int number2 = 1; number2 <= n; number2 += 2)
    {
        Console.Write($"{number1}{number2}{number1 * number2} ");
    }
}