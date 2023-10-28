List<int> firstNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> secondNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();


List<int> mergedNumbers = new List<int>();

int maxLength = Math.Max(firstNumbers.Count, secondNumbers.Count);

for (int i = 0; i < maxLength; i++)
{
    if (i < firstNumbers.Count)
    {
        mergedNumbers.Add(firstNumbers[i]);
    }

    if (i < secondNumbers.Count)
    {
        mergedNumbers.Add(secondNumbers[i]);
    }
}

Console.WriteLine(string.Join(" ", mergedNumbers));