namespace _3._04_cwiczenie.classes;

public abstract class Pracownik
{
    protected string Imie { get; set; }
    protected string Nazwisko { get; set; }
    protected int Wiek { get; set; }
    protected int Wyplata;

    public string getInfo()
    {
        return $"{Imie} {Nazwisko}, {Wiek}, {Wyplata}";
    }
    
}

public class Makuperka : Pracownik { }
public class Barber : Pracownik { }
public class Kosmetyczka : Pracownik { }
public class Manikiurzystka : Pracownik { }