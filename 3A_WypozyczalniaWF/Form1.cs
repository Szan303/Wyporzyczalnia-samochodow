using _3A_WypozyczalniaWF.Models;
using System.ComponentModel;
using _3A_WypozyczalniaWF.Data;

namespace _3A_WypozyczalniaWF
{
    public partial class Form1 : Form
    {
        BindingList<Samochod> flota = new();
        BindingList<Klient> klienci = new();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;

            FormClosing += Form1_Closing;
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            flota.Clear();
            flota = new BindingList<Samochod>(Storage.LoadFlota());
            dgvFlota.DataSource = flota;
            dgvFlota.Columns["CenaZaDzien"].HeaderText = "Cena za dzieñ";
            dgvFlota.Columns["CenaZaDzien"].DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00 z³" };
            klienci.Clear();
            klienci = new BindingList<Klient>(Storage.LoadKlienci());
            dgvKlienci.DataSource = klienci;
        }

        void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            ZapiszWszystko();
        }

        void ZapiszWszystko()
        {
            Storage.SaveFlota(flota);
            Storage.SaveKlienci(klienci);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using var dlg = new Forms.FormAuto();
            //dlg.ShowDialog(this);



            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Wynik != null)
            {
                flota.Add(dlg.Wynik);
            }

        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dgvFlota.CurrentRow?.DataBoundItem is Samochod s)
            {
                using var dlg = new Forms.FormAuto(s);

                if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Wynik != null)
                {
                    var wynik = dlg.Wynik;
                    s.Marka = wynik.Marka;
                    s.Model = wynik.Model;
                    s.Rok = wynik.Rok;
                    s.CenaZaDzien = wynik.CenaZaDzien;

                    switch (s, wynik)
                    {
                        case (Osobowy so, Osobowy no): so.LiczbaMiejsc = no.LiczbaMiejsc; break;
                        case (Dostawczy sd, Dostawczy nd): sd.LadownoscKG = nd.LadownoscKG; break;
                        case (Sportowy ss, Sportowy ns): ss.Przyspieszenie = ns.Przyspieszenie; break;
                        default:
                            int idx = flota.IndexOf(s);
                            wynik.id = s.id;
                            flota[idx] = wynik;
                            break;
                    }
                    dgvFlota.Refresh();
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
           
            if (dgvFlota.CurrentRow?.DataBoundItem is Samochod s)
            {
                flota.Remove(s);
            }
        }

        private void btnKlienciDodaj_Click(object sender, EventArgs e)
        {
            using var dlg = new Forms.FormKlienci();
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Wynik != null)
            {
                klienci.Add(dlg.Wynik);
            }
        }

        private void btnKlienciEdytuj_Click(object sender, EventArgs e)
        {
            if (dgvKlienci.CurrentRow?.DataBoundItem is Klient s)
            {
                using var dlg = new Forms.FormKlienci(s);

                if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Wynik != null)
                {
                    var wynik = dlg.Wynik;
                    var imie = wynik.Imie;
                    var nazwisko = wynik.Nazwisko;
                    var telefon = wynik.Telefon;

                    int idx = klienci.IndexOf(s);
                    wynik.Id = s.Id;
                    klienci[idx] = wynik;
                    
                    dgvKlienci.Refresh();
                }
            }
        }

        private void btnKlienciUsun_Click(object sender, EventArgs e)
        {
            if (dgvKlienci.CurrentRow?.DataBoundItem is Klient k)
            {
                klienci.Remove(k);
            }
        }
    }
}
