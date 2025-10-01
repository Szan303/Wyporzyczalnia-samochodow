using _3A_WypozyczalniaWF.Models;
using System.Data;

namespace _3A_WypozyczalniaWF.Forms
{
    public partial class FormKlienci : Form
    {
        Klient? edytowalny;
        public Klient Wynik { get; set; }

        public FormKlienci(Klient? k = null)
        {
            InitializeComponent();
            edytowalny = k;
            if (k != null)
            {
                txtImie.Text = k.Imie;
                txtNazwisko.Text = k.Nazwisko;
                txtTelefon.Text = k.Telefon;
            }

        }

        private void btnKlienciZapisz_Click(object sender, EventArgs e)
        {
            var isnull = string.IsNullOrWhiteSpace;
            if (isnull(txtImie.Text) || isnull(txtNazwisko.Text) || isnull(txtTelefon.Text)) 
            {
                MessageBox.Show("Uzupełnij imię, nazwisko i telefon!!");
                return;
            }
            var imie = txtImie.Text.Trim();
            var nazwisko = txtNazwisko.Text.Trim();
            var telefon = txtTelefon.Text.Trim();

            try 
            {
                Klient nowy = new Klient(imie, nazwisko, telefon);

                Wynik = nowy;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
