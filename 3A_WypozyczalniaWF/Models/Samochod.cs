using Newtonsoft.Json;

namespace _3A_WypozyczalniaWF.Models
{
    public class Samochod
    {
        public Guid id { get; set; } = Guid.NewGuid();
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

        public virtual string Szczegoly => string.Empty;
    }


        public class Osobowy : Samochod
        {
            public override string Szczegoly => $"Liczba miejsc: {LiczbaMiejsc}";
            public int LiczbaMiejsc { get; set; }

            public Osobowy(string marka, string model, int rok, decimal cenaZaDzien, int liczbaMiejsc)
                : base(marka, model, rok, cenaZaDzien)
            {
                LiczbaMiejsc = liczbaMiejsc;
            }

            public override string Opis() => base.Opis() + $", Typ: Osobowy, Liczba miejsc: {LiczbaMiejsc}, Cena: {CenaZaDzien} zł/dzień.";
        }

        public class Dostawczy : Samochod
        {
             public override string Szczegoly => $"Ładowność: {LadownoscKG}";
            public int LadownoscKG { get; set; }

            public Dostawczy(string marka, string model, int rok, decimal cenaZaDzien, int ladownoscKG)
                : base(marka, model, rok, cenaZaDzien)
            {
                LadownoscKG = ladownoscKG;
            }

            public override string Opis() => base.Opis() + $", Typ: Dostawczy, Ładowność: {LadownoscKG}, Cena: {CenaZaDzien} zł/dzień.";
        }

        public class Sportowy : Samochod
        {
            public override string Szczegoly => $"Przyśpieszenie: {Przyspieszenie}";
            public double Przyspieszenie { get; set; }

            public Sportowy(string marka, string model, int rok, decimal cenaZaDzien, double przyspieszenie)
                : base(marka, model, rok, cenaZaDzien)
            {
                Przyspieszenie = przyspieszenie;
            }

            public override string Opis() => base.Opis() + $", Typ: Sportowy, O-100: {Przyspieszenie}, Cena: {CenaZaDzien} zł/dzień.";
        }
    }

