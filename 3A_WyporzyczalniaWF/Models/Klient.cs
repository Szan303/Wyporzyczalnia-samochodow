using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_WyporzyczalniaWF.Models
{
    public class Klient
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
}
