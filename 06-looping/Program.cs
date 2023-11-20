// looping: for, while, do while, foreach

Console.Write("Masukkan bilangan pertama: ");
var bilanganPertama = Console.ReadLine();
int bilanganPertamaInt;
var canConvertBilanganPertama = int.TryParse(bilanganPertama, out bilanganPertamaInt);

Console.Write("Masukkan bilangan kedua: ");
var bilanganKedua = Console.ReadLine();
int bilanganKeduaInt;
var canConvertBilanganKedua = int.TryParse(bilanganKedua, out bilanganKeduaInt);

if (!canConvertBilanganPertama)
{
    Console.WriteLine("Bilangan pertama tidak valid");
}
else if (!canConvertBilanganKedua)
{
    Console.WriteLine("Bilangan kedua tidak valid");
}
else if (bilanganPertamaInt > bilanganKeduaInt)
{
    Console.WriteLine("Bilangan kedua harus lebih besar dari bilangan pertama.");
}
else
{
    for (int i = bilanganPertamaInt + 1; i < bilanganKeduaInt; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"Bilangan genap: {i}");
        }
        else
        {
            Console.WriteLine($"Bilangan ganjil: {i}");
        }
    }
}
