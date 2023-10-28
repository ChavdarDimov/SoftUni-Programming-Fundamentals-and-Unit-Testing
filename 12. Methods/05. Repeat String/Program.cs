string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = repeatString(text, count);

static string repeatString(string text, int count)
{
    string output = "";

    for (int i = 0; i < count; i++)
    {
        output += text;
    }

    return output;
}

Console.WriteLine(result);

