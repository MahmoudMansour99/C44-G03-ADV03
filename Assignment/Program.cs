namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> myBook = new List<Book>
            {
                new Book ("65465", "C#", new[] {"Mahmoud", "Mansour"}, new DateTime(2019, 05, 5), 39.99m),
                new Book ("654865", "JS", new[] {"Mahmoud", "Mansour"}, new DateTime(2022, 05, 5), 45.99m),
            };

            // User Defined
            BookDelegatefPtr title = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(myBook, title);

            Console.WriteLine("/////////////////");
            
            // Built In Delegate
            Func<Book, string> author = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(myBook, author);

            Console.WriteLine("/////////////////");

            // Anonymouth Methods
            Func<Book, string> ISBN = delegate (Book book) { return book.ISBN; };
            LibraryEngine.ProcessBooks(myBook, ISBN);

            Console.WriteLine("/////////////////");

            // Lambda Expressions
            Func<Book, string> date =  (Book book) => { return book.PublicationDate.ToString(); };
            LibraryEngine.ProcessBooks(myBook, date);

        }
    }
}
