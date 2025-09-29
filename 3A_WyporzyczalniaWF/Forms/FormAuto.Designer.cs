namespace _3A_WyporzyczalniaWF.Forms
{
    partial class FormAuto
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
            CenaZaDzien = new Label();
            Marka = new TextBox();
            Model = new TextBox();
            button1 = new Button();
            label5 = new Label();
            numRok = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numRok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(70, 52);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(70, 127);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(70, 213);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 2;
            label3.Text = "Rocznik";
            // 
            // CenaZaDzien
            // 
            CenaZaDzien.AutoSize = true;
            CenaZaDzien.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic);
            CenaZaDzien.Location = new Point(70, 286);
            CenaZaDzien.Name = "CenaZaDzien";
            CenaZaDzien.Size = new Size(139, 30);
            CenaZaDzien.TabIndex = 3;
            CenaZaDzien.Text = "CenaZaDzień";
            // 
            // Marka
            // 
            Marka.Location = new Point(70, 85);
            Marka.Name = "Marka";
            Marka.Size = new Size(166, 23);
            Marka.TabIndex = 4;
            // 
            // Model
            // 
            Model.Location = new Point(70, 160);
            Model.Name = "Model";
            Model.Size = new Size(100, 23);
            Model.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(80, 386);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 8;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 9);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 9;
            label5.Text = "Dodaj samochód";
            // 
            // numRok
            // 
            numRok.Location = new Point(70, 246);
            numRok.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numRok.Minimum = new decimal(new int[] { 2025, 0, 0, 0 });
            numRok.Name = "numRok";
            numRok.Size = new Size(85, 23);
            numRok.TabIndex = 10;
            numRok.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(70, 319);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(277, 213);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 12;
            label4.Text = "Typ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "OSOBOWE", "DOSTAWCZE", "SPORTOWE" });
            comboBox1.Location = new Point(277, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(numRok);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(Model);
            Controls.Add(Marka);
            Controls.Add(CenaZaDzien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAuto";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numRok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label CenaZaDzien;
        private TextBox Marka;
        private TextBox Model;
        private Button button1;
        private Label label5;
        private NumericUpDown numRok;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ComboBox comboBox1;
    }
}