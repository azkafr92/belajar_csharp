var a = true;

// if, else-if, else
if (a == true)
{
    Console.WriteLine("It's true");
}
else if (a == false)
{
    Console.WriteLine("It's false");
}
else
{
    Console.WriteLine("Invalid a");
}

// switch
var day = 1;
switch (day)
{
    case 0:
        Console.WriteLine("It's Sunday");
        break;
    case 1:
        Console.WriteLine("It's Monday");
        break;
    case 2:
        Console.WriteLine("It's Tuesday");
        break;
    default:
        Console.WriteLine("What day is it?");
        break;
}

// ternary
var b = a ? "true" : "false";
Console.WriteLine($"b is {b}");
