List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> endOutput = new List<int>();

int n = numbers.Count / 2;

for (int i = 0; i < n; i++)
{
    int sum = numbers[i] + numbers[numbers.Count - 1 - i];
    endOutput.Add(sum);
}

if (numbers.Count % 2 == 1)
{
    endOutput.Add(numbers[n]);
}

Console.WriteLine(string.Join(" ", endOutput));