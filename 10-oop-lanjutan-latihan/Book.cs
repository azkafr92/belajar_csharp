class Book : Item, IBorrowable
{
    public Book(string title, int year) : base(title, year)
    {
        Author = "Anonymous";
        Isbn = "";
    }

    public Book(string title, int year, string author, string isbn) : base(title, year)
    {
        Author = author;
        Isbn = isbn;
    }

    public string Author { get; }
    public string Isbn { get; }

    public override void Display()
    {
        Console.WriteLine($"Book: {Title}, year: {Year}), author: {Author}, ISBN: {Isbn}");
    }

    public void Borrow()
    {
        Console.WriteLine($"Borrowing book: {Title}");
    }

    public void Return()
    {
        Console.WriteLine($"Returning book: {Title}");
    }
}