using _3A_WypozyczalniaWF.Models;
using System.ComponentModel;
using _3A_WypozyczalniaWF.Data;

namespace _3A_WypozyczalniaWF
{
    public partial class Form1 : Form
    {
        BindingList<Samochod> flota = new();

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
        }

        void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            ZapiszWszystko();
        }

        void ZapiszWszystko()
        {
            Storage.SaveFlota(flota);
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
    }
}
