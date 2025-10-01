using _3A_WypozyczalniaWF.Models;

namespace _3A_WypozyczalniaWF.Forms
{
    public partial class FormAuto : Form
    {
        Samochod? edytowalny;
        public Samochod? Wynik { get; set; }

        public FormAuto(Samochod? s = null)
        {
            InitializeComponent();
            edytowalny = s;

            if (s == null) cboTyp.SelectedIndex = 0; // jezeli nowy to ustaw na Osobowy;

            if (s != null)
            {
                txtMarka.Text = s.Marka;
                txtModel.Text = s.Model;
                numRok.Value = s.Rok;
                numCena.Value = s.CenaZaDzien;

                if (s is Osobowy o)
                {
                    cboTyp.SelectedItem = "OSOBOWY";
                    numParam.DecimalPlaces = 0;
                    numParam.Value = o.LiczbaMiejsc;
                    lblParam.Text = "Liczba miejsc";
                }

                if (s is Dostawczy d)
                {
                    cboTyp.SelectedItem = "DOSTAWCZY";
                    numParam.DecimalPlaces = 0;
                    numParam.Value = d.LadownoscKG;
                    lblParam.Text = "Ładowność [kg]";
                }

                if (s is Sportowy sp)
                {
                    cboTyp.SelectedItem = "SPORTOWY";
                    numParam.DecimalPlaces = 1;
                    numParam.Value = (decimal)sp.Przyspieszenie;
                    lblParam.Text = "Przyśpieszenie [s]";
                }
            }

            cboTyp.SelectedIndexChanged += (a, b) => UstawEtykieteParametru();
        }


        private void UstawEtykieteParametru()
        {
            if (cboTyp.SelectedItem == "OSOBOWY")
            {
                lblParam.Text = "Liczba miejsc";
                numParam.DecimalPlaces = 0;
                numParam.Minimum = 4;
                numParam.Value = 4;
            }

            else if (cboTyp.SelectedItem == "DOSTAWCZY")
            {
                lblParam.Text = "Ładowność [kg]";
                numParam.DecimalPlaces = 0;
                numParam.Minimum = 100;
            }

            else if (cboTyp.SelectedItem == "SPORTOWY")
            {
                lblParam.Text = "Przyśpieszenie [s]";
                numParam.DecimalPlaces = 1;
                numParam.Minimum = 1;
                numParam.Value = 1;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Uzupełnij markę i model!");
                return;
            }

            var marka = txtMarka.Text.Trim();
            var model = txtModel.Text.Trim();
            var rok = numRok.Value;
            var cena = numCena.Value;
            var typ = cboTyp.SelectedItem;

            try
            {
                Samochod nowy = typ switch
                {
                    "OSOBOWY" => new Osobowy(marka, model, (int)rok, cena, (int)numParam.Value),
                    "DOSTAWCZY" => new Dostawczy(marka, model, (int)rok, cena, (int)numParam.Value),
                    "SPORTOWY" => new Sportowy(marka, model, (int)rok, cena, (double)numParam.Value)
                };

                if (edytowalny != null) nowy.id = edytowalny.id;

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
