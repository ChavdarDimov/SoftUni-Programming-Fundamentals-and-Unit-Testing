int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

int result = GetMultipleOfEvenAndOdds(number);

Console.WriteLine(result);

int GetMultipleOfEvenAndOdds(int number)
{
    int sumOfOdds = GetSumOfOddDigits(number);
    int sumOfEvens = GetSumOfEvenDigits(number);

    int sumOfAll = sumOfOdds * sumOfEvens;

    return sumOfAll;
}

int GetSumOfEvenDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;

        if (digit % 2 == 0)
        {
            sum += digit;
        }
    }

    return sum;
}

int GetSumOfOddDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        number = number / 10;

        if (digit % 2 != 0)
        {
            sum += digit;
        }
    }

    return sum;
}