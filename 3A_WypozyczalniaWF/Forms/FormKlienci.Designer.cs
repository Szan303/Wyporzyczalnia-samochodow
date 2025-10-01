namespace _3A_WypozyczalniaWF.Forms
{
    partial class FormKlienci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKlienciZapisz = new Button();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtTelefon = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 50);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 116);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 181);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // btnKlienciZapisz
            // 
            btnKlienciZapisz.Location = new Point(282, 291);
            btnKlienciZapisz.Name = "btnKlienciZapisz";
            btnKlienciZapisz.Size = new Size(75, 23);
            btnKlienciZapisz.TabIndex = 3;
            btnKlienciZapisz.Text = "Zapisz";
            btnKlienciZapisz.UseVisualStyleBackColor = true;
            btnKlienciZapisz.Click += btnKlienciZapisz_Click;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(45, 68);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 4;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(45, 134);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(100, 23);
            txtNazwisko.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(45, 199);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 6;
            // 
            // FormKlienci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefon);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(btnKlienciZapisz);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormKlienci";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKlienciZapisz;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtTelefon;
    }
}