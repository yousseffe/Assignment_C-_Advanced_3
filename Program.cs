using Assignment_C__Advanced_3.book;

namespace Assignment_C__Advanced_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("1" , "C#" , new string[] {"youssef" , "nabeh"} , new DateTime(2020 , 1  , 1) , 40m),
                new Book("1" , "OOP" , new string[] {"youssef" , "Mohamed"} , new DateTime(2022 , 1  , 1) , 60m),

            };
            Console.WriteLine("Books title");
            LibraryEngine.ProcessBooks(books , BookFunctions.GetTitle);

            Console.WriteLine("Books Authors");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            Console.WriteLine("Books Price");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

            Console.WriteLine("Books ID");
            LibraryEngine.ProcessBooks(books , delegate(Book book ) { return book.ISBN; });

            Console.WriteLine("Books Publication Date");
            LibraryEngine.ProcessBooks(books, book =>   book.PublicationDate.ToString());
            books.Find

        }
    }
}
