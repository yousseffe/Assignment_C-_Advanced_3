using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_3.book
{
    public delegate string BookFunctionDelegate(Book B);

    public class LibraryEngine
    {
        public static void ProcessBooks (List<Book> books , BookFunctionDelegate Fptr) 
        {
            foreach (Book book in books)
            {
                Console.WriteLine(Fptr(book));
            }
        }
    }
}
