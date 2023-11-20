class Program
{
    static void Main(string[] args)
    {
        // membaca input di Terminal
        Console.Write("Masukkan nama anda: ");
        var name = Console.ReadLine();

        Console.WriteLine($"Halo, {name}");

        Console.Write("Masukkan nilai 'a': ");
        var nilaiA = Console.ReadLine();
        if (nilaiA == null || decimal.Parse(nilaiA) < 1)
        {
            Console.WriteLine("Nilai 'a' tidak valid");
            return;
        }

        Console.Write("Masukkan nilai 'b': ");
        var nilaiB = Console.ReadLine();
        if (nilaiB == null || decimal.Parse(nilaiB) < 1)
        {
            Console.WriteLine("Nilai 'b' tidak valid");
            return;
        }

        Console.Write("Masukkan nilai 'c': ");
        var nilaiC = Console.ReadLine();
        if (nilaiC == null || decimal.Parse(nilaiC) < 1)
        {
            Console.WriteLine("Nilai 'c' tidak valid");
            return;
        }

        var x1 = X1(double.Parse(nilaiA), double.Parse(nilaiB), double.Parse(nilaiC));
        var x2 = X2(double.Parse(nilaiA), double.Parse(nilaiB), double.Parse(nilaiC));

        Console.WriteLine($"Nilai x1: {x1}");
        Console.WriteLine($"Nilai x2: {x2}");
    }


    static double X1(double a, double b, double c)
    {
        return (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
    }

    static double X2(double a, double b, double c)
    {
        return (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
    }
}
