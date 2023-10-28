string type = Console.ReadLine();

if (type == "int")
{
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    Console.WriteLine(compareNumbers(number1, number2));
}
else if (type == "char")
{
    char char1 = char.Parse(Console.ReadLine());
    char char2 = char.Parse(Console.ReadLine());
    Console.WriteLine(compareCharacters(char1, char2));
}
else if (type == "string")
{
    string string1 = Console.ReadLine();
    string string2 = Console.ReadLine();
    Console.WriteLine(compareStrings(string1, string2));
}

static int compareNumbers (int number1, int number2)
{
    int output = 0;

    if (number1 > number2)
    {
        output = number1;
    }
    else if (number1 < number2)
    {
        output = number2;
    }

    return output;
}

static char compareCharacters (char char1, char char2)
{
    int output = 0;

    if (char1 > char2)
    {
        output = char1;
    }
    else if (char1 < char2)
    {
        output = char2;
    }

    return (char)output;
}

static string compareStrings (string string1, string string2)
{
    int compare = string1.CompareTo(string2);
    string output = "";

    if (compare > 0)
    {
        output = string1;
    }
    else if (compare < 0)
    {
        output = string2;
    }

    return output;
}