using _3A_WyporzyczalniaWF.Models;
using Newtonsoft.Json;


namespace _3A_WyporzyczalniaWF.Data
{
    public class Storage
    {
        //Ścieżki do plików JSON z danymi
        static readonly string flotaPath = "flota.json";
        static readonly string klienciPath = "klienci.json";
        static readonly string wypozyczeniaPath = "wypozyczenia.json";

        static readonly JsonSerializerSettings settings = new()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };

        //Odczyt Floty
        public static List<Samochod> LoadFlota()
            => File.Exists(flotaPath)
            ? JsonConvert.DeserializeObject<List<Samochod>>(File.ReadAllText(flotaPath), settings) ?? new() : new();
        //Zapis Floty
        public static void SaveFlota(IEnumerable<Samochod> flota)
            => File.WriteAllText(flotaPath, JsonConvert.SerializeObject(flota, settings));
        //Odczyt Klientów
        public static List<Klient> LoadKlienci()
            => File.Exists(klienciPath)
            ? JsonConvert.DeserializeObject<List<Klient>>(File.ReadAllText(klienciPath), settings) ?? new() : new();
        //Zapis Klientów
        public static void SaveKlienci(IEnumerable<Klient> klienci)
            => File.WriteAllText(klienciPath, JsonConvert.SerializeObject(klienci, settings));
        //Odczyt Wypożyczeń
        public static List<Wyporzyczenie> LoadWypozyczenia()
            => File.Exists(wypozyczeniaPath)
            ? JsonConvert.DeserializeObject<List<Wyporzyczenie>>(File.ReadAllText(wypozyczeniaPath), settings) ?? new() : new();
        //Zapis Wypożyczeń
        public static void SaveWypozyczenia(IEnumerable<Wyporzyczenie> wypozyczenia)
            => File.WriteAllText(wypozyczeniaPath, JsonConvert.SerializeObject(wypozyczenia, settings));
    }
}