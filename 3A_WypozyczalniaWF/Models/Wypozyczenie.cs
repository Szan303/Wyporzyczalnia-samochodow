

namespace _3A_WypozyczalniaWF.Models
{
    public enum StatusWypozyczenia
    {
        Aktywne, // 0 
        Zwrócone // 1
    }
    public class Wypozyczenie
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public Guid KlientId { get; set; }
        public Guid AutoId { get; set; }
        public DateTime DataOd { get; set; }
        public DateTime DataDo { get; set; }
        public StatusWypozyczenia Status { get; set; } = StatusWypozyczenia.Aktywne;
        public decimal CenaZaDzien { get; set; }

        public int Dni()
        {
            int dni = (int)(DataDo.Date - DataOd.Date).TotalDays;

            if (dni == 0) dni = 1;

            return dni;
        }

    }
}
