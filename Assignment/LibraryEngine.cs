using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string BookDelegatefPtr(Book b);
    public class LibraryEngine
    {
        public static void ProcessBooks (List<Book> books, BookDelegatefPtr fPtr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }

        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
