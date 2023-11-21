class Program
{
    public static void Main(string[] args)
    {
        Book book = new(title: "The Great Gatsby", year: 1925, author: "F. Scott Fitzgerald", isbn: "978-0743270755");
        Magazine magazine = new(title: "National Geographic", year: 2022, issueNumber: "10");

        book.Display();
        book.Borrow();
        book.Return();

        magazine.Display();
    }
}