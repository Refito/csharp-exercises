using System;

namespace Old_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var favoriteBook = Console.ReadLine();
            var bookCount = int.Parse(Console.ReadLine());

            for (int bookId = 0; bookId < bookCount; bookId++)
            {
                var bookName = Console.ReadLine();

                if (bookName == favoriteBook)
                { 
                    Console.WriteLine($"You checked {bookId} and found it.");
                    return;
                }
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {bookCount} books.");
        }
    }
}
