namespace BookManagementSystemSan
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }
        public string Language { get; set; }
        public string LoT { get; set; }
        public string Summary { get; set; }

        public Book(int bookID, string bookName, string isbn, decimal price, string publisher, int numberOfPages, string language = "English", string loT = "Technical", string summary = "")
        {
            //Checking the length of bookID is equal to 5
            if (bookID.ToString().Trim().Length != 5) throw new ArgumentException("Book ID should have 5 digits only.");
            //Checking the bookName is empty or not
            if (string.IsNullOrWhiteSpace(bookName)) throw new ArgumentException("Book Name cannot be blank.");

            BookID = bookID;
            BookName = bookName;
            ISBN = isbn;
            Price = price;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
            Language = language;
            LoT = loT;
            Summary = summary;
        }

        //Override the Method ToString 
        //And return the book details along with it.
        public override string ToString()
        {
            return $"\n\nID-: {BookID},\nName: {BookName}, \nISBN: {ISBN}, \nPrice: {Price}, \nPublisher: {Publisher}, \nPages: {NumberOfPages}, \nLanguage: {Language}, \nLoT: {LoT}, \nSummary: {Summary}\n\n--------------------------";
        }

    }

}
