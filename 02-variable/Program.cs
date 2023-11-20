// deklarasi variable
// penamaan variable menggunakan camelCase
// penamaan class, method, & property menggunakan PascalCase
// penamaan konstanta menggunakan caps underscore

// cara 1: tipe_variabel nama_variable;
// assign value di baris berbeda
int angka1;
angka1 = 10;

decimal angka2;
angka2 = 10.2M;

string kata1;
kata1 = "Hello";

string kata2;
kata2 = "World";

Console.WriteLine(angka1);
Console.WriteLine(angka2);
Console.WriteLine(kata1);
Console.WriteLine(kata2);

// cara 2: tipe_variable nama_variable = value;
double angka3 = 10.2;
Console.WriteLine(angka3);

// cara 3: var nama_variable = value;
var kata3 = "Azka";
Console.WriteLine(kata3);

// string interpolation
Console.WriteLine("{0} - {1}", angka1, angka2);
Console.WriteLine($"{angka3}");
Console.WriteLine($"Name: {kata3}");
Console.WriteLine("Kota: {0}", "Bekasi");

// constant
const string DB_NAME = "api";
Console.WriteLine(DB_NAME);