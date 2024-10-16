namespace WFA24101601;

internal class Dolgozat
{
    public string Nev { get; set; }
    public int Pontszam { get; set; }

    public Dolgozat(string nev, int pontszam)
    {
        Nev = nev;
        Pontszam = pontszam;
    }
}
