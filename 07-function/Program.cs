static int Addition(int a, int b)
{
    return a + b;
}

static int Subtraction(int a, int b)
{
    return a - b;
}

static int Multiplication(int a, int b)
{
    return a * b;
}

static int Division(int a, int b)
{
    return a / b;
}

var a = 10;
var b = 2;

Console.WriteLine(Addition(a, b));
Console.WriteLine(Subtraction(a, b));
Console.WriteLine(Multiplication(a, b));
Console.WriteLine(Division(a, b));

