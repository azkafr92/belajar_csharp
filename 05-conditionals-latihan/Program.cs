/*
Inputan angka: 1 - 100
output:
 100 = print = luar biasa
 99 - 80 = baik
 60 - 79 = cukup
 10 - 59 = kurang
 < 10 = tidak baik 

inputan < 1 atau > 100 
output --> salah input
*/
Console.Write("Masukkan angka 1 - 100: ");
var angka = Console.ReadLine();
int angkaInt;
var canConvert = int.TryParse(angka, out angkaInt);
if (!canConvert || angkaInt < 1 || angkaInt > 100)
{
    Console.WriteLine("salah input");
}
else if (angkaInt < 10)
{
    Console.WriteLine("tidak baik");

}
else if (angkaInt < 60)
{
    Console.WriteLine("kurang");
}
else if (angkaInt < 80)
{
    Console.WriteLine("cukup");
}
else if (angkaInt < 100)
{
    Console.WriteLine("baik");
}
else
{
    Console.WriteLine("luar biasa");
}
