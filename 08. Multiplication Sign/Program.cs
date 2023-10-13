int number1 = int.Parse(Console.ReadLine());
int number2  = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

ProductCompare(number1, number2, number3);

static void ProductCompare(int n1, int n2, int n3)
{
    if (n1 > 0 && n2 > 0 && n3 > 0)
    {
        Console.WriteLine("positive");
    }

    if (n1 < 0 && n2 < 0 && n3 > 0)
    {
        Console.WriteLine("positive");
    }

    if (n1 > 0 && n2 < 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }

    if (n1 < 0 && n2 > 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }

    if (n1 < 0 && n2 > 0 && n3 > 0)
    {
        Console.WriteLine("negative");
    }

    if (n1 > 0 && n2 < 0 && n3 > 0)
    {
        Console.WriteLine("negative");
    }

    if (n1 > 0 && n2 > 0 && n3 < 0)
    {
        Console.WriteLine("negative");
    }

    if (n1 < 0 && n2 < 0 && n3 < 0)
    {
        Console.WriteLine("negative");
    }

    if (n1 == 0 || n2 == 0 || n3  == 0)
    {
        Console.WriteLine("zero");
    }
}