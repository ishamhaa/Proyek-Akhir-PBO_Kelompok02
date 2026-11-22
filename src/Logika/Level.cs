namespace Logika;

public class Level
{
    private readonly List<Butir> daftarButir = new();

    public int Nomor { get; }
    public IReadOnlyList<Butir> DaftarButir => daftarButir.AsReadOnly();

    public Level(int nomor)
    {
        if (nomor < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(nomor), "Nomor level harus dimulai dari 1.");
        }

        Nomor = nomor;
    }

    public void TambahButir(Butir butir)
    {
        ArgumentNullException.ThrowIfNull(butir);
        daftarButir.Add(butir);
    }
}
