class Pegawai
{
    public Pegawai()
    {
        this.namaPertama = "John";
        this.namaAkhir = "Doe";
    }

    public Pegawai(string namaPertama, string namaAkhir)
    {
        this.namaPertama = namaPertama;
        this.namaAkhir = namaAkhir;
    }

    private readonly string namaPertama;
    private readonly string namaAkhir;

    public string NamaLengkap
    {
        get { return $"{this.namaPertama} {this.namaAkhir}"; }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Pegawai pegawai = new(namaPertama: "Azka", namaAkhir: "Fadhli");
        Console.WriteLine($"Hello, {pegawai.NamaLengkap}");
    }
}
