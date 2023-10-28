List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

List<int> bombAndPower = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int bombNumber = bombAndPower[0];
int bombPower = bombAndPower[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNumber)
    {
        int leftBound = Math.Max(0, i - bombPower);
        int rightBound = Math.Min(numbers.Count - 1, i + bombPower);

        numbers.RemoveRange(leftBound, rightBound - leftBound + 1);
        i = 0;
    }
}

int sum = numbers.Sum();
Console.WriteLine(sum);