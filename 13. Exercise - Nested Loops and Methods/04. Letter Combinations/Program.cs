char letter1 = char.Parse(Console.ReadLine());
char letter2 = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());

int counter = 0;

for (char combination1 = letter1;  combination1 <= letter2; combination1++)
{
    for (char combination2 = letter1; combination2 <= letter2; combination2++)
    {
        for (char combination3 = letter1; combination3 <= letter2; combination3++)
        {
            if (combination1 != excludedLetter && combination2 != excludedLetter && combination3 != excludedLetter)
            {
                counter++;
                Console.Write($"{combination1}{combination2}{combination3} ");
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine(counter);