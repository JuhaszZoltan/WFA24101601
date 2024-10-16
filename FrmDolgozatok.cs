using System.Text;

namespace WFA24101601;

public partial class FrmDolgozatok : Form
{
    //DRY == Don't repeat yourself!


    private List<Dolgozat> dolgozatok = new();
    private const string mentesiHely = "..\\..\\..\\src\\save.txt";

    public FrmDolgozatok()
    {
        InitializeComponent();
        this.Load += FrmDolgozatokLoad;
        this.FormClosing += FrmDolgozatokFormClosing;
        btnAdatbevitel.Click += BtnAdatbevitelClick;
    }

    private void UIhozAd(Dolgozat d)
    {
        rtbDolgozatok.Text += $"{d.Nev,-23} {d.Pontszam,3} pont\n";
        lblAtlag.Text = $"{dolgozatok.Average(d => d.Pontszam):0.00} pont";
    }


    private void BtnAdatbevitelClick(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tbNev.Text) || !int.TryParse(tbPontszam.Text, out _))
        {
            _ = MessageBox.Show(
                caption: "HIBA!",
                text: "Valamelyik beviteli mezõ formátuma nem megfelelõ!",
                icon: MessageBoxIcon.Error,
                buttons: MessageBoxButtons.OK);
            return;
        }

        dolgozatok.Add(new(nev: tbNev.Text, pontszam: int.Parse(tbPontszam.Text)));

        UIhozAd(dolgozatok[^1]);

        tbNev.Text = null;
        tbPontszam.Text = null;

        tbNev.Select();
    }

    private void FrmDolgozatokFormClosing(object? sender, FormClosingEventArgs e)
    {
        using StreamWriter sw = new(
            path: mentesiHely,
            append: false,
            encoding: Encoding.UTF8);

        foreach (var d in dolgozatok) sw.WriteLine($"{d.Nev};{d.Pontszam}");
    }

    private void FrmDolgozatokLoad(object? sender, EventArgs e)
    {
        using StreamReader sr = new(
            path: mentesiHely,
            encoding: Encoding.UTF8);

        while (!sr.EndOfStream)
        {
            string[] v = sr.ReadLine().Split(';');
            dolgozatok.Add(new(nev: v[0], pontszam: int.Parse(v[1])));
            UIhozAd(dolgozatok[^1]);
        }            
    }
}
