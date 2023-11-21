class Student(Guid id, string name, int age)
{

    public Guid Id { get; } = id;
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public Course[] Courses { get; set; } = [];

    public override string ToString()
    {
        string courses = "[";
        foreach (Course course in Courses)
        {
            courses += course.ToString() + ", ";
        }
        courses += "]";
        return $"Student(Id: {Id}, Name: {Name}, Age: {Age}, Courses: {courses})";
    }
}