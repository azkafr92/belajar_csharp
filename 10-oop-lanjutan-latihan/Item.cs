abstract class Item
{
    public Item()
    {
        Title = "Untitled";
    }

    public Item(string title, int year)
    {
        Title = title;
        Year = year;
    }

    public string Title { get; }
    public int Year { get; }

    public abstract void Display();
}