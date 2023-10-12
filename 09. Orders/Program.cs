string product = Console.ReadLine();
productPriceCalc(product);

static void productPriceCalc (string product)
{
    double totalPrice = 0;

    if (product == "coffee")
    {
        int quantity = int.Parse(Console.ReadLine());
        totalPrice = quantity * 1.50;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else if (product == "water")
    {
        int quantity = int.Parse(Console.ReadLine());
        totalPrice = quantity * 1.00;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else if (product == "coke")
    {
        int quantity = int.Parse(Console.ReadLine());
        totalPrice = quantity * 1.40;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else if (product == "snacks")
    {
        int quantity = int.Parse(Console.ReadLine());
        totalPrice = quantity * 2.00;
        Console.WriteLine($"{totalPrice:f2}");
    }
}