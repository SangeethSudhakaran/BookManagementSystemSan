namespace BookManagementSystemSan
{
    public class BookManager
    {
        //List to add and delete books
        private List<Book> booksList = new List<Book>();

        //List of LoT for validation
        //Only from this LoT are considered
        private readonly List<string> validLoT = new List<string> { ".NET", "Java", "IMS", "V&V", "BI", "RDBMS", "Technical" };

        //Adding book to bookList
        public void AddBook(Book book)
        {
            if (!validLoT.Contains(book.LoT)) throw new ArgumentException("Invalid LoT value.");
            booksList.Add(book);
        }

        //Display Books from List
        public void ListBooks()
        {
            if (booksList.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            //Loop through bookList
            foreach (var book in booksList)
            {
                Console.WriteLine(book);
            }
        }

        //Delete book from List by passing bookId
        public void RemoveBook(int bookID)
        {
            var book = booksList.FirstOrDefault(b => b.BookID == bookID);
            if (book != null)
            {
                booksList.Remove(book);
                Console.WriteLine("Book removed");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }

}
