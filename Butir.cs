namespace Logika;

public abstract class Butir
{
    public string Id { get; }
    public string Teks { get; }

    protected Butir(string id, string teks)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);
        ArgumentException.ThrowIfNullOrWhiteSpace(teks);

        Id = id;
        Teks = teks;
    }

    public abstract string Instruksi { get; }
}
