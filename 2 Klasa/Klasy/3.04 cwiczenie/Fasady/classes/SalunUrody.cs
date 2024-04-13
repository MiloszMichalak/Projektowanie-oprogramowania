namespace _3._04_cwiczenie.classes;

public class SalunUrody
{
    private Lokal Lokal;
    private List<Pracownik> pracownicy = new ();
    private List<Wyposazenie> Wyposazenie = new();

    public void setLokal(Lokal lokal)
    {
        Lokal = lokal;
    }

    public void DodajPracownika(Pracownik pracownik)
    {
        pracownicy.Add(pracownik);
    }

    public void DodajWyposazenie(Wyposazenie wyposazenie)
    {
        Wyposazenie.Add(wyposazenie);
    }

}