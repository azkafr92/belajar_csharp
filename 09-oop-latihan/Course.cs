class Course(Guid id, string name, string code)
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
    public string Code { get; } = code;
    public Student[] Students { get; set; } = [];

    public override string ToString()
    {
        return $"Course(Id: {Id}, Name: {Name}, Code: {Code})";
    }
}