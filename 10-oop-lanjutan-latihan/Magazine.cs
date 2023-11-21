using System.Reflection;

class Magazine : Item
{
    public Magazine(string title, int year) : base(title, year)
    {
        IssueNumber = "";
    }

    public Magazine(string title, int year, string issueNumber) : base(title, year)
    {
        IssueNumber = issueNumber;
    }
    public string IssueNumber { get; }

    public override void Display()
    {
        Console.WriteLine($"Magazine: {Title}, year: {Year}, issue number: {IssueNumber})");
    }
}