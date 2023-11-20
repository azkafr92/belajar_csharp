var a = 8;
var b = 5;

// operator aritmatika: + - * / % ++ --
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}");
Console.WriteLine($"a % b = {a % b}");
a++;
Console.WriteLine($"a++ = {a}");
b++;
Console.WriteLine($"b++ = {b}");
a--;
Console.WriteLine($"a-- = {a}");
b--;
Console.WriteLine($"b-- = {b}");

// operator perbandingan: < > <= >= == !=
Console.WriteLine($"a < b: {a < b}");
Console.WriteLine($"a > b: {a > b}");
Console.WriteLine($"a <= b: {a <= b}");
Console.WriteLine($"a >= b: {a >= b}");
Console.WriteLine($"a == b: {a == b}");
Console.WriteLine($"a != b: {a != b}");

// operator logika: && || !
var c = true;
var d = false;
Console.WriteLine($"c && d: {c && d}");
Console.WriteLine($"c || d: {c || d}");
Console.WriteLine($"!c : {!c}");
Console.WriteLine($"!d : {!d}");
