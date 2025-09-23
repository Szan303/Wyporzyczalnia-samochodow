// importy 
using Newtonsoft.Json;
using System.Xml;
#region SAMOCHOD
// klasa samochód 
class Samochod
{
    public Guid id {  get; set; } = Guid.NewGuid();
    // deklaracja właściwości
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Rok { get; set; }
    private decimal cenaZaDzien;
    // sprawdzanie czy cena jest w poprawnym zakresie
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
    // konstruktor
    public Samochod(string marka, string model, int rok, decimal cenaZaDzien)
    {
        // inicjalizacja właściwości
        Marka = marka;
        Model = model;
        Rok = rok;
        CenaZaDzien = cenaZaDzien;
    }
    // metoda opisująca samochód
    public virtual string Opis() => $"Samochód: {Marka} {Model} ({Rok})";
}
// klasy dziedziczące po klasie Samochod
class Osobowy : Samochod
{
    public int LiczbaMiejsc { get; set; }
    public Osobowy(string marka, string model, int rok, decimal cenaZaDzien, int
    liczbaMiejsc)
    : base(marka, model, rok, cenaZaDzien)
    {
        LiczbaMiejsc = liczbaMiejsc;
    }
    // nadpisanie metody Opis
    public override string Opis() => base.Opis() + $", Typ: Osobowy, Liczba miejsc: {LiczbaMiejsc}, Cena: {CenaZaDzien}zł / dzień.";
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
    // nadpisanie metody Opis
    public override string Opis() => base.Opis() + $", Typ: Dostawczy, Ładowność: {LadownoscKG}, Cena: {CenaZaDzien} zł / dzień.";
}
class Sportowy : Samochod
{

    public double Przyspieszenie { get; set; }
    // konstruktor z wywołaniem konstruktora bazowego
    public Sportowy(string marka, string model, int rok, decimal cenaZaDzien, double
    przyspieszenie)
    : base(marka, model, rok, cenaZaDzien)
    {
        Przyspieszenie = przyspieszenie;
    }
    // nadpisanie metody Opis
    public override string Opis() => base.Opis() + $", Typ: Sportowy, O-100: {Przyspieszenie}, Cena: {CenaZaDzien} zł / dzień.";
}
#endregion
#region KLIENT

// klasa klient
class Klient
{
    // deklaracja właściwości
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Telefon { get; set; }
    // konstruktor
    public Klient(string imie, string nazwisko, string telefon)
    {
        // inicjalizacja właściwości
        Imie = imie;
        Nazwisko = nazwisko;
        Telefon = telefon;
    }
    // metoda zwracająca dane klienta w formacie tekstowym
    public string DaneKlienta() => $"{Id} - {Imie} {Nazwisko}, tel: {Telefon}.";
}
#endregion
#region Wyporzyczenia


enum StatusWyporzyczenia { Aktywne, Zwrócone }
class Wyporzyczenie
{
    public Guid id { get; set; } = Guid.NewGuid();
    public Guid KlientId { get; set; }
    public Guid AutoId { get; set; }
    public DateTime DataOd { get; set; }
    public DateTime DataDo { get; set; }
    public StatusWyporzyczenia Status { get; set; } = StatusWyporzyczenia.Aktywne;
    public decimal CenaZaDzien { get; set; }
    public int Dni()
    {
        int dni = (int)(DataDo.Date - DataOd.Date).TotalDays;

        if(dni == 0)
        {
            dni = 1;
        }
        return dni;
    }

}
#endregion
// klasa główna programu
class Program
{
    // lista samochodów i klientów oraz ścieżki do plików JSON
    static List<Samochod> flota = new();
    static List<Klient> klienci = new();
    static List<Wyporzyczenie> wyporzyczenia = new();
    static string sciezkaDoPliku = "flota.json";
    static string sciezkaKlienci = "klienci.json";
    static string sciezkaWyporzyczenia = "wyporzyczenia.json";
    static void Main()
    {
        // wczytanie danych z pliku przy starcie programu
        WczytajZPliku();
        // pętla menu głównego
        while (true)
        {
            // wyczyszczenie ekranu i wyświetlenie menu
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            // ASCII art samochodu
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
            // obsługa wyboru użytkownika
            if (wybor == "1") { PokazAuta(); Pauza(); }
            else if (wybor == "2") { DodajAuto(); ZapiszDoPliku(); }
            else if (wybor == "3") ObliczKoszt();
            else if (wybor == "4") { UsunAuto(); ZapiszDoPliku(); }
            else if (wybor == "5") { EdytujAuto(); ZapiszDoPliku(); }
            else if (wybor == "6") SzukajAuta();
            else if (wybor == "7") MenuKlienci();
            else if (wybor == "8") MenuWyporzyczenia();
            else if (wybor == "0") break;
        }
    }
    // metoda pauzy przed powrotem do menu poprostu menu znika i czeka na klawisz i powraca do menu
    static void Pauza()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nNaciśnij dowolny klawicz aby powrócić do menu głównego.");
        Console.ResetColor();
        Console.ReadKey(true);
    }
    #region AUTA
    // metody obsługujące samochody
    static void PokazAuta()
    {
        // wyczyszczenie ekranu i wyświetlenie listy samochodów
        Console.Clear();
        Console.WriteLine("*** FLOTA ***");
        int i = 1;
        foreach (var a in flota)
            Console.WriteLine($"{i++}. {a.Opis()}");
    }
    // metoda dodająca samochód do floty
    static void DodajAuto()
    {
        // wczytanie danych samochodu od użytkownika
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
                // wczytanie dodatkowej właściwości dla samochodu osobowego
                Console.Write("Liczba miejsc: ");
                int miejsca = int.Parse(Console.ReadLine());
                flota.Add(new Osobowy(marka, model, rok, cena, miejsca));
            }
            else if (typ == 2)
            {
                // wczytanie dodatkowej właściwości dla samochodu dostawczego
                Console.Write("Ładowność: ");
                int ladownosc = int.Parse(Console.ReadLine());
                flota.Add(new Dostawczy(marka, model, rok, cena, ladownosc));
            }
            else if (typ == 3)
            {
                // wczytanie dodatkowej właściwości dla samochodu sportowego
                Console.Write("Przyśpieszenie: ");
                double przyspieszenie = double.Parse(Console.ReadLine());
                flota.Add(new Sportowy(marka, model, rok, cena, przyspieszenie));
            }
        }
        // obsługa wyjątku ArgumentOutOfRangeException
        catch (ArgumentOutOfRangeException ex)
        {
            // obługa błędu i wyświetlenie komunikatu
            Console.WriteLine($"Błąd: {ex.ParamName}");
        }
    }
    // metoda obliczająca koszt wypożyczenia samochodu
    static void ObliczKoszt()
    {
        // wyczyszczenie ekranu i wyświetlenie listy samochodów
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
    // metoda usuwająca samochód z floty
    static void UsunAuto()
    {
        // wyczyszczenie ekranu i wyświetlenie listy samochodów
        PokazAuta();
        Console.Write("Podaj numer auta do usunięcia: ");
        int idx = int.Parse(Console.ReadLine()) - 1;
        var auto = flota[idx];
        Console.WriteLine($"Usunięto {auto.Opis()}");
        flota.RemoveAt(idx);
    }
    // metody do zapisu i odczytu danych z pliku JSON
    static void WczytajZPliku()
    {
        // wczytanie danych z pliku JSON przy starcie programu
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
        if (File.Exists(sciezkaWyporzyczenia))
        {
            var json = File.ReadAllText(sciezkaWyporzyczenia);
            wyporzyczenia = JsonConvert.DeserializeObject<List<Wyporzyczenie>>(json,
            new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        }
        else
        {
            wyporzyczenia = new List<Wyporzyczenie>();
        }
    }
    static void ZapiszDoPliku()
    {
        // zapisanie danych do pliku JSON po każdej zmianie floty
        var json = JsonConvert.SerializeObject(flota, Newtonsoft.Json.Formatting.Indented,
        new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        File.WriteAllText(sciezkaDoPliku, json);
        // zapisanie danych do pliku JSON po każdej zmianie wyporzyczeń
        var json2 = JsonConvert.SerializeObject(wyporzyczenia, Newtonsoft.Json.Formatting.Indented,
        new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        File.WriteAllText(sciezkaWyporzyczenia, json2);
    }
    static void EdytujAuto()
    {
        //  wyczyszczenie ekranu i wyświetlenie listy samochodów
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
        // wyczyszczenie ekranu i wyświetlenie menu wyszukiwania
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
            // różne opcje wyszukiwania
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
    // metody obsługujące klientów
    static void MenuKlienci()
    {
        while (true)
        {
            // wyczyszczenie ekranu i wyświetlenie menu klientów
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
            else if (wybor == "3") { EdytujKlienta(); ZapiszKlientowDoPliku(); Pauza(); }
            else if (wybor == "4") { UsunKlienta(); ZapiszKlientowDoPliku(); Pauza(); }
            else if (wybor == "0") break;
        }
    }
    static void DodajKlienta()
    {
        //  wczytanie danych klienta od użytkownika
        Console.WriteLine("*** DODAJ KLIENTA ***");
        Console.Write("Imię: "); var imie = Console.ReadLine();
        Console.Write("Nazwisko: "); var nazwisko = Console.ReadLine();
        Console.Write("Telefon: "); var telefon = Console.ReadLine();
        klienci.Add(new Klient(imie, nazwisko, telefon));
        Console.WriteLine("Klient został dodany!");
    }
    static void ZapiszKlientowDoPliku()
    {
        // zapisanie danych klientów do pliku JSON po każdej zmianie
        var json = JsonConvert.SerializeObject(klienci, Newtonsoft.Json.Formatting.Indented,
        new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        File.WriteAllText(sciezkaKlienci, json);
    }
    static void ListaKlientow()
    {
        // wyczyszczenie ekranu i wyświetlenie listy klientów
        Console.Clear();
        Console.WriteLine("*** LISTA KLIENTÓW ***");
        int i = 1;
        foreach (var k in klienci)
            Console.WriteLine($"{i++}. {k.DaneKlienta()}");
    }
    static void EdytujKlienta()
    {
        Console.Clear();
        Console.WriteLine("*** EDYCJA KLIENTÓW");
        ListaKlientow();
        Console.WriteLine("Podaj numer klienta do edycji");
        int idx = int.Parse(Console.ReadLine()) - 1;
        var klient = klienci[idx];
        Console.WriteLine($"\n Edytujesz: {klient.Nazwisko} {klient.Imie} ");
        Console.WriteLine($"Imie ({klient.Imie}): ");
        string imie = Console.ReadLine();
        klient.Imie = imie;
        Console.WriteLine($"Nazwisko ({klient.Nazwisko}): ");
        string nazwisko = Console.ReadLine();
        klient.Nazwisko = nazwisko;
        Console.WriteLine($"Numer telefonu ({klient.Telefon}): ");
        string telefon = Console.ReadLine();
        klient.Telefon = telefon;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Zaktualizowano!");
        Console.ResetColor();

    }
    static void UsunKlienta()
    {
        Console.Clear();

        ListaKlientow();
        Console.WriteLine("Podaj numer klienta do usunięcia: ");
        int idx = int.Parse(Console.ReadLine()) - 1;
        var klient = klienci[idx];
        Console.WriteLine($"Usunięto {klient.Id}");
        klienci.RemoveAt(idx);
    }
    #endregion
    #region WYPOŻYCZENIA
    static void MenuWyporzyczenia()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Wyporzyczenia ===");
            Console.WriteLine("1. Nowe wypożyczenie");
            Console.WriteLine("2. Lista aktywnych wypożyczeń");
            Console.WriteLine("3. ");
            Console.WriteLine("0. Powrót");


            Console.Write("Opcja: ");
            var wybor = Console.ReadLine();
            if (wybor == "1") { NoweWyporzyczenie(); }
            else if (wybor == "2") { ListaWyporzyczen(); }
            else if (wybor == "3") { }
            else if (wybor == "4") break;

        }
    }
    static void NoweWyporzyczenie()
    {
        Console.Clear();
        if (!klienci.Any())
        {
            Console.WriteLine("Brak klientów!"); return;
        }
        if (!flota.Any())
        {
            Console.WriteLine("Brak samochodów!"); return;
        }

        //Console.WriteLine("*** DODAJ WYPORZYCZENIE ***");
        ListaKlientow();
        Console.Write("Numer klienta: ");
        int kid = int.Parse(Console.ReadLine());
        var klient = klienci[kid];
        
        PokazAuta();
        Console.Write("Numer auta: ");
        int aid = int.Parse(Console.ReadLine());

        var auto = flota[aid];

        Console.Write("Data od (YYYY-MM-DD): ");
        DateTime data_od = DateTime.Parse(Console.ReadLine());

        Console.Write("Data do (YYYY-MM-DD): ");
        DateTime data_do = DateTime.Parse(Console.ReadLine());

        if (data_do < data_od)
        {
            Console.WriteLine("Data DO nie może być wcześniej niż OD!"); return;
        }
        if(!CzyAutoDostepne(auto.id, data_od, data_do))
        {
            Console.WriteLine("Auto niedostępne w podanym terminie!");
        }
        else
        {
            var w = new Wyporzyczenie
            {
                KlientId = klient.Id,
                AutoId = auto.id,
                DataOd = data_od,
                DataDo = data_do,
                Status = StatusWyporzyczenia.Aktywne,
                CenaZaDzien = auto.CenaZaDzien
            };

            wyporzyczenia.Add(w);

            Console.WriteLine("Utworzono wypożyczenie.");
        }


    }

    static bool CzyAutoDostepne(Guid autoID, DateTime data_od, DateTime data_do)
    {
        return !wyporzyczenia.Any(w => w.AutoId == autoID &&
        w.Status == StatusWyporzyczenia.Aktywne &&
        !(data_do.Date < w.DataOd.Date ||
                data_od > w.DataDo.Date));
    }
    static void ListaWyporzyczen()
    {
        //Console.Clear();
        //Console.WriteLine("*** FLOTA ***");
        //int i = 1;
        //foreach (var a in flota)
        //    Console.WriteLine($"{i++}. {a.Opis()}");
        Console.Clear();
        Console.WriteLine("*** WYPOŻYCZENIA ***");
        int i = 1;
        var aktywne = wyporzyczenia.Where(w=>w.Status == StatusWyporzyczenia.Aktywne).ToList();
        if (!aktywne.Any())
            {
                Console.WriteLine("Brak aktywnych wypożyczeń!"); return;
            }
        foreach (var w in aktywne)
        {
            var k = klienci.FirstOrDefault(x => x.Id == w.KlientId);
            var a = flota.FirstOrDefault(x => x.id == w.AutoId);
            string klientNazwa = $"{k.Nazwisko} {k.Imie}";
            string autoNazwa = $"{a.Marka} {a.Model}";
            Console.WriteLine($"{i++}. [{w.Status}] {klientNazwa} - {autoNazwa} | {w.DataOd} - {w.DataDo}");
            
        }
    }


    #endregion
}
