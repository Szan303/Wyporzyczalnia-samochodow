using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_WyporzyczalniaWF.Models
{
    public enum StatusWyporzyczenia { Aktywne, Zwrócone }
    public class Wyporzyczenie
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

            if (dni == 0)
            {
                dni = 1;
            }
            return dni;
        }

    }
}
