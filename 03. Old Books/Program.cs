namespace _03._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String favouriteBook = Console.ReadLine();

            String nextBook = Console.ReadLine();

            int checkedBooksCount = 0;
            String booksInput = "";

            while (favouriteBook != booksInput && booksInput != "No More Books")
            {
                booksInput = Console.ReadLine();
                checkedBooksCount++;
            }

            if (booksInput == favouriteBook)
            {
                Console.Write($"You checked {checkedBooksCount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooksCount} books.");
            }

            //if (booksInput == "No More Books")
            //{
            //    Console.WriteLine("The book you search is not here!");
            //    Console.WriteLine($"You checked {checkedBooksCount} books.");
            //}
            //else if (booksInput == favouriteBook)
            //{
            //    Console.Write($"You checked {checkedBooksCount} books and found it.");
            //}
        }
    }
}