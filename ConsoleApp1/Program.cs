using Newtonsoft.Json;
using System.Xml;
#region SAMOCHOD
class Samochod
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Rok { get; set; }
    private decimal cenaZaDzien;
    public decimal CenaZaDzien
    {
        get => cenaZaDzien;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("CenaZaDzien nie może być mniejsza od 0!");
            }
            else
            {
                cenaZaDzien = value;
            }
        }
    }
    public Samochod(string marka, string model, int rok, decimal cenaZaDzien)
    {
        Marka = marka;
        Model = model;
        Rok = rok;
        CenaZaDzien = cenaZaDzien;
    }
    public virtual string Opis() => $"Samochód: {Marka} {Model} ({Rok})";
}
class Osobowy : Samochod
{
    public int LiczbaMiejsc { get; set; }
    public Osobowy(string marka, string model, int rok, decimal cenaZaDzien, int
    liczbaMiejsc)
    : base(marka, model, rok, cenaZaDzien)
    {
        LiczbaMiejsc = liczbaMiejsc;
    }
    public override string Opis() => base.Opis() + $", Typ: Osobowy, Liczba miejsc: {LiczbaMiejsc}, Cena: { CenaZaDzien}zł / dzień.";
}
class Dostawczy : Samochod
{
    public int LadownoscKG { get; set; }
    public Dostawczy(string marka, string model, int rok, decimal cenaZaDzien, int
    ladownoscKG)
    : base(marka, model, rok, cenaZaDzien)
    {
        LadownoscKG = ladownoscKG;
    }
    public override string Opis() => base.Opis() + $", Typ: Dostawczy, Ładowność: {LadownoscKG}, Cena: { CenaZaDzien} zł / dzień.";
}
class Sportowy : Samochod
{
    public double Przyspieszenie { get; set; }
    public Sportowy(string marka, string model, int rok, decimal cenaZaDzien, double
    przyspieszenie)
    : base(marka, model, rok, cenaZaDzien)
    {
        Przyspieszenie = przyspieszenie;
    }
    public override string Opis() => base.Opis() + $", Typ: Sportowy, O-100: {Przyspieszenie}, Cena: { CenaZaDzien} zł / dzień.";
}
#endregion
#region KLIENT
class Klient
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Telefon { get; set; }
    public Klient(string imie, string nazwisko, string telefon)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Telefon = telefon;
    }
    public string DaneKlienta() => $"{Id} - {Imie} {Nazwisko}, tel: {Telefon}.";
}
#endregion
class Program
{
    static List<Samochod> flota = new();
    static List<Klient> klienci = new();
    static string sciezkaDoPliku = "flota.json";
    static string sciezkaKlienci = "klienci.json";
    static void Main()
    {
        WczytajZPliku();
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
      _______
      // ||\ \
_____//___||_\ \___
) _ _ \
|_/ \________/ \___|
___\_/________\_/______
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Wypożyczalnia samochodów ===");
            Console.ResetColor();
            Console.WriteLine("1. Pokaż samochody");
            Console.WriteLine("2. Dodaj samochód");
            Console.WriteLine("3. Oblicz koszt");
            Console.WriteLine("4. Usuń samochód");
            Console.WriteLine("5. Edytuj samochód");
            Console.WriteLine("6. Szukaj samochód");
            Console.WriteLine("--------------------");
            Console.WriteLine("7. Klienci");
            Console.WriteLine("8. Wypozyczenia");
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Wyjdź!");
            Console.Write("Opcja: ");
            var wybor = Console.ReadLine();
            if (wybor == "1") { PokazAuta(); Pauza(); }
            else if (wybor == "2") { DodajAuto(); ZapiszDoPliku(); }
            else if (wybor == "3") ObliczKoszt();
            else if (wybor == "4") { UsunAuto(); ZapiszDoPliku(); }
            else if (wybor == "5") { EdytujAuto(); ZapiszDoPliku(); }
            else if (wybor == "6") SzukajAuta();
            else if (wybor == "7") MenuKlienci();
            else if (wybor == "0") break;
        }
    }
    static void Pauza()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nNaciśnij dowolny klawicz aby powrócić do menu głównego.");
        Console.ResetColor();
        Console.ReadKey(true);
    }
    #region AUTA
    static void PokazAuta()
    {
        Console.Clear();
        Console.WriteLine("*** FLOTA ***");
        int i = 1;
        foreach (var a in flota)
            Console.WriteLine($"{i++}. {a.Opis()}");
    }
    static void DodajAuto()
    {
        Console.WriteLine("1. Osobowy 2. Dostawczy 3. Sportowy");
        Console.Write("Typ: ");
        int typ = int.Parse(Console.ReadLine());
        Console.Write("Marka: ");
        string marka = Console.ReadLine();
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("Rok: ");
        int rok = int.Parse(Console.ReadLine());
        Console.Write("Cena za dzień: ");
        decimal cena = decimal.Parse(Console.ReadLine());
        try
        {
            if (typ == 1)
            {
                Console.Write("Liczba miejsc: ");
                int miejsca = int.Parse(Console.ReadLine());
                flota.Add(new Osobowy(marka, model, rok, cena, miejsca));
            }
            else if (typ == 2)
            {
                Console.Write("Ładowność: ");
                int ladownosc = int.Parse(Console.ReadLine());
                flota.Add(new Dostawczy(marka, model, rok, cena, ladownosc));
            }
            else if (typ == 3)
            {
                Console.Write("Przyśpieszenie: ");
                double przyspieszenie = double.Parse(Console.ReadLine());
                flota.Add(new Sportowy(marka, model, rok, cena, przyspieszenie));
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Błąd: {ex.ParamName}");
        }
    }
    static void ObliczKoszt()
    {
        PokazAuta();
        Console.Write("Wybierz numer auta: ");
        var autoID = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Ilość dni: ");
        var dni = int.Parse(Console.ReadLine());
        var auto = flota[autoID];
        decimal cena = auto.CenaZaDzien;
        decimal koszt = dni * cena;
        Console.WriteLine($" Koszt wypożyczenia: {koszt} zł");
    }
    static void UsunAuto()
    {
        PokazAuta();
        Console.Write("Podaj numer auta do usunięcia: ");
        int idx = int.Parse(Console.ReadLine()) - 1;
        var auto = flota[idx];
        Console.WriteLine($"Usunięto {auto.Opis()}");
        flota.RemoveAt(idx);
    }
    static void WczytajZPliku()
    {
        if (File.Exists(sciezkaDoPliku))
        {
            var json = File.ReadAllText(sciezkaDoPliku);
            flota = JsonConvert.DeserializeObject<List<Samochod>>(json,
            new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        }
        else
        {
            flota = new List<Samochod>();
        }
        if (File.Exists(sciezkaKlienci))
        {
            var json = File.ReadAllText(sciezkaKlienci);
            klienci = JsonConvert.DeserializeObject<List<Klient>>(json,
            new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        }
        else
        {
            klienci = new List<Klient>();
        }
    }
    static void ZapiszDoPliku()
    {
        var json = JsonConvert.SerializeObject(flota, Newtonsoft.Json.Formatting.Indented,
        new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        File.WriteAllText(sciezkaDoPliku, json);
    }
    static void EdytujAuto()
    {
        PokazAuta();
        Console.Write("Podaj numer auta do edycji: ");
        int idx = int.Parse(Console.ReadLine()) - 1;
        var auto = flota[idx];
        Console.WriteLine($"\nEdytujesz auto: {auto.Opis()}");
        Console.Write($"Nowa marka ({auto.Marka}): ");
        string marka = Console.ReadLine();
        auto.Marka = marka;
        Console.Write($"Nowy model ({auto.Model}): ");
        string model = Console.ReadLine();
        auto.Model = model;
        Console.Write($"Rok produkcji ({auto.Rok}): ");
        int rok = int.Parse(Console.ReadLine());
        auto.Rok = rok;
        Console.Write($"Nowa cena ({auto.CenaZaDzien}): ");
        decimal cena = decimal.Parse(Console.ReadLine());
        auto.CenaZaDzien = cena;
        if (auto is Osobowy osobowy)
        {
            Console.Write($"Liczba miejsc ({osobowy.LiczbaMiejsc}): ");
            int miejsca = int.Parse(Console.ReadLine());
            osobowy.LiczbaMiejsc = miejsca;
        }
        else if (auto is Dostawczy dostawczy)
        {
            Console.Write($"Ładowność ({dostawczy.LadownoscKG}): ");
            int ladownosc = int.Parse(Console.ReadLine());
            dostawczy.LadownoscKG = ladownosc;
        }
        else if (auto is Sportowy sportowy)
        {
            Console.Write($"Przyspieszenie 0-100km ({sportowy.Przyspieszenie}): ");
            double przyspieszenie = double.Parse(Console.ReadLine());
            sportowy.Przyspieszenie = przyspieszenie;
        }
    }
    static void SzukajAuta()
    {
        Console.WriteLine("\n *** Szukaj samochodu ***");
        Console.WriteLine("1. Po marce");
        Console.WriteLine("2. Po typie");
        Console.WriteLine("3. Po cenie maksymalnej");
        Console.WriteLine("4. Po roku produkcji");
        Console.Write("Wybierz opcje: ");
        var opcja = Console.ReadLine();
        IEnumerable<Samochod> wynik = flota;
        switch (opcja)
        {
            case "1":
                Console.Write("Podaj markę: ");
                string marka = Console.ReadLine().ToLower();
                wynik = flota.Where(a => a.Marka.ToLower().Contains(marka));
                break;
            case "2":
                Console.WriteLine("Wybierz typ: 1. Osobowe, 2. Dostawcze, 3. Sportowe");
                Console.Write("Typ: ");
                string typ = Console.ReadLine();
                if (typ == "1")
                {
                    wynik = flota.Where(a => a is Osobowy);
                }
                else if (typ == "2")
                {
                    wynik = flota.Where(a => a is Dostawczy);
                }
                else if (typ == "3")
                {
                    wynik = flota.Where(a => a is Sportowy);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy typ!");
                }
                break;
            case "3":
                Console.Write(" Podaj maksymalną cenę za dzień: ");
                decimal max_cena = decimal.Parse(Console.ReadLine());
                wynik = flota.Where(a => a.CenaZaDzien <= max_cena);
                break;
            case "4":
                Console.Write(" Rok produkcji: ");
                int rok = int.Parse(Console.ReadLine());
                wynik = flota.Where(a => a.Rok >= rok);
                break;
        }
        Console.WriteLine("\n Wyniki wyszukiwania");
        if (!wynik.Any())
        {
            Console.WriteLine("Brak wyników wyszukiwania!");
        }
        else
        {
            int i = 1;
            foreach (var auto in wynik)
            {
                Console.WriteLine($"{i++}. {auto.Opis()}");
            }
        }
    }
    #endregion
    #region KLIENCI
    static void MenuKlienci()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== KLIENCI ===");
            Console.ResetColor();
            Console.WriteLine("1. Lista klientów");
            Console.WriteLine("2. Dodaj");
            Console.WriteLine("3. Edytuj");
            Console.WriteLine("4. Usuń");
            Console.WriteLine("--------------------");
            Console.WriteLine("0. Powrót");
            Console.Write("Opcja: ");
            var wybor = Console.ReadLine();
            if (wybor == "1") { ListaKlientow(); Pauza(); }
            else if (wybor == "2") { DodajKlienta(); ZapiszKlientowDoPliku(); }
            else if (wybor == "0") break;
        }
    }
    static void DodajKlienta()
    {
        Console.WriteLine("*** DODAJ KLIENTA ***");
        Console.Write("Imię: "); var imie = Console.ReadLine();
        Console.Write("Nazwisko: "); var nazwisko = Console.ReadLine();
        Console.Write("Telefon: "); var telefon = Console.ReadLine();
        klienci.Add(new Klient(imie, nazwisko, telefon));
        Console.WriteLine("Klient został dodany!");
    }
    static void ZapiszKlientowDoPliku()
    {
        var json = JsonConvert.SerializeObject(klienci, Newtonsoft.Json.Formatting.Indented,
        new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        File.WriteAllText(sciezkaKlienci, json);
    }
    static void ListaKlientow()
    {
        Console.Clear();
        Console.WriteLine("*** LISTA KLIENTÓW ***");
        int i = 1;
        foreach (var k in klienci)
            Console.WriteLine($"{i++}. {k.DaneKlienta()}");
    }
    #endregion
}