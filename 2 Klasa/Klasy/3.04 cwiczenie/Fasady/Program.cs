using _3._04_cwiczenie.classes;

namespace _3._04_cwiczenie;

class Program
{
    static void Main(string[] args)
    {
        Kosmetyczka kosmetyczka1 = new Kosmetyczka();
        Kosmetyczka kosmetyczka2 = new Kosmetyczka();
        Barber barber = new Barber();
        Manikiurzystka manikiurzystka = new Manikiurzystka();

        Lokal lokal = new Lokal();
        lokal.Adres = "Dymbiec";
        lokal.NumerTelefonu = "997";
        lokal.Czynsz = 999.99;

        Wyposazenie szampon = new Wyposazenie();
        szampon.Nazwa = "hediszadi";

        Wyposazenie grzebien = new Wyposazenie();
        grzebien.Nazwa = "Widelcowy";

        SalunUrody salunUrody = new SalunUrody();
        salunUrody.setLokal(lokal);
        
        salunUrody.DodajPracownika(manikiurzystka);
        salunUrody.DodajPracownika(kosmetyczka1);
        salunUrody.DodajPracownika(kosmetyczka2);
        
        salunUrody.DodajWyposazenie(szampon);
        salunUrody.DodajWyposazenie(grzebien);


    }
}
