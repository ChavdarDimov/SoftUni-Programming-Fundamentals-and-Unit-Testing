using System.Diagnostics.Metrics;

string text = Console.ReadLine();
VowelsCounter(text);

static void VowelsCounter(string text)
{
    int counter = 0;

    for (int letter = 0; letter < text.Length; letter++)
    {
        char outputLetter = text[letter];
        if (outputLetter == 'A' || outputLetter == 'a' 
            || outputLetter == 'E' || outputLetter == 'e' 
            || outputLetter == 'I' || outputLetter == 'i' 
            || outputLetter == 'O' || outputLetter == 'o' 
            || outputLetter == 'U' || outputLetter == 'u')
        {
            counter++;
        }
    }

    Console.WriteLine(counter);
}