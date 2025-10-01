

namespace _3A_WypozyczalniaWF.Models
{
    public class Klient
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
}
