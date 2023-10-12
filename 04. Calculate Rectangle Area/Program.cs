int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int area = rectangleArea(width, height);

static int rectangleArea(int width, int height)
{
    return width * height;
}

Console.WriteLine(area);