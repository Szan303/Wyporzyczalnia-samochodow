namespace _3A_WyporzyczalniaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var dlg = new Forms.FormAuto();
            dlg.ShowDialog(this);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using var dlg = new Forms.FormAuto();
            dlg.ShowDialog(this);

        }
    }
}
