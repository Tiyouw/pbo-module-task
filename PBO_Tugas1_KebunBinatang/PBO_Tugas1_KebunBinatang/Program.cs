
class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string namaHewan, int umurHewan)
    {
        Nama = namaHewan;
        Umur = umurHewan;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"\n- INFORMASI HEWAN -\nNama: {Nama}\nUmur: {Umur} tahun\n";
    }
}

class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string namaHewan, int umurHewan, int jumlahKakiHewan) : base(namaHewan, umurHewan)
    {
        JumlahKaki = jumlahKakiHewan;
    }

    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $"Jumlah Kaki: {JumlahKaki}";
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string namaHewan, int umurHewan, double panjangTubuhHewan) : base(namaHewan, umurHewan)
    {
        PanjangTubuh = panjangTubuhHewan;
    }

    public override string Suara()
    {
        return "Reptil ini bersuara.";
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $"Panjang tubuh: {PanjangTubuh} meter";
    }
}

class Singa : Mamalia
{
    public Singa(string namaHewan, int umurHewan, int jumlahKakiHewan) : base(namaHewan, umurHewan, jumlahKakiHewan) { }

    public override string Suara()
    {
        return "Singa mengaum keras";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} mengaum keras.");
    }
}

class Gajah : Mamalia
{
    public Gajah(string namaHewan, int umurHewan, int jumlahKakiHewan) : base(namaHewan, umurHewan, jumlahKakiHewan) { }

    public override string Suara()
    {
        return "Gajah MMMMBRRRRRRRR gatau sauranya lek.";
    }
}

class Ular : Reptil
{
    public Ular(string namaHewan, int umurHewan, double panjangTubuhHewan) : base(namaHewan, umurHewan, panjangTubuhHewan) { }

    public override string Suara()
    {
        return "Ular bersuara 'xixixixixixixixixixi'.";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap.");
    }
}

class Buaya : Reptil
{
    public Buaya(string namaHewan, int umurHewan, double panjangTubuhHewan) : base(namaHewan, umurHewan, panjangTubuhHewan) { }

    public override string Suara()
    {
        return "Buaya berkata 'Kiw cwek'";
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine(hewan.Suara());
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa Alaska", 9, 4);
        Gajah gajah = new Gajah("Gajah Duduk", 4, 4);
        Ular ular = new Ular("Ular Rawr", 1, 7);
        Buaya buaya = new Buaya("Buaya Florida", 3, 3);
        Reptil reptil = new Buaya("Buaya Dangkal", 2, 2);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);
        kebunBinatang.TambahHewan(reptil);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nBentuk Polimorisme:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());
        Console.WriteLine(reptil.Suara());

        Console.WriteLine("\nMetode Khusus:");
        singa.Mengaum();
        ular.Merayap();
    }
}