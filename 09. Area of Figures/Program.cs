namespace _9._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double area = 0.0;

            if (figure == "square")
            {
                double figureSize = double.Parse(Console.ReadLine());
                area = figureSize * figureSize;
                Console.WriteLine("{0:f2}", area);
            }

            else if (figure == "rectangle")
            {
                double figureSizeHeight = double.Parse(Console.ReadLine());
                double figureSizeWidth = double.Parse(Console.ReadLine());
                area = figureSizeHeight * figureSizeWidth;
                Console.WriteLine("{0:f2}", area);
            }

            else if (figure == "circle")
            {
                double figureSize = double.Parse(Console.ReadLine());
                area = Math.PI * figureSize * figureSize;
                Console.WriteLine("{0:f2}", area);
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }

            // Console.WriteLine("{0:f2}", area);
        }
    }
}