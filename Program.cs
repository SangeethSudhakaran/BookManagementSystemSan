namespace BookManagementSystemSan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            //User choice menu loop
            while (true)
            {
                Console.WriteLine("Book Management System");
                Console.WriteLine("1 - Add Book");
                Console.WriteLine("2 - List Books");
                Console.WriteLine("3 - Remove Book");
                Console.WriteLine("4 - Exit from Book Management");
                Console.Write("Please enter your choice ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook(manager);
                        break;
                    case "2":
                        manager.ListBooks();
                        break;
                    case "3":
                        RemoveBooks(manager);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        //Taking inputs from user for adding book
        static void AddBook(BookManager manager)
        {
            try
            {
                Console.Write("Enter Book ID (5 digits): ");
                int bookID = int.Parse(Console.ReadLine());
                Console.Write("Enter Book Name: ");
                string bookName = Console.ReadLine();
                Console.Write("Enter ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Enter Price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Enter Publisher: ");
                string publisher = Console.ReadLine();
                Console.Write("Enter Number of Pages: ");
                int numberOfPages = int.Parse(Console.ReadLine());
                Console.Write("Enter Language (optional, default 'English'): ");
                string language = Console.ReadLine();
                language = string.IsNullOrWhiteSpace(language) ? "English" : language;
                Console.Write("Enter LoT (optional, default 'Technical'): ");
                string loT = Console.ReadLine();
                loT = string.IsNullOrWhiteSpace(loT) ? "Technical" : loT;
                Console.Write("Enter Summary (optional): ");
                string summary = Console.ReadLine();

                Book book = new Book(bookID, bookName, isbn, price, publisher, numberOfPages, language, loT, summary);
                manager.AddBook(book);
                Console.WriteLine("Book added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        //Get bookId from user
        static void RemoveBooks(BookManager manager)
        {
            try
            {
                Console.Write("Enter BookID to delete - ");
                int bookID = int.Parse(Console.ReadLine());
                manager.RemoveBook(bookID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured : {ex.Message}");
            }
        }
    }
}