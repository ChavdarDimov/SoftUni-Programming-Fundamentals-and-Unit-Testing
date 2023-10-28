int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sumOfOdd = 0;
int sumOfEven = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumOfOdd += number;
    }
    else
    {
        sumOfEven += number;
    }
}

Console.WriteLine(sumOfOdd - sumOfEven);