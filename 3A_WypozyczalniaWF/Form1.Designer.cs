namespace _3A_WypozyczalniaWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            costam = new TabControl();
            tabPage1 = new TabPage();
            btnUsun = new Button();
            btnEdytuj = new Button();
            btnDodaj = new Button();
            dgvFlota = new DataGridView();
            tabPage2 = new TabPage();
            btnKlienciUsun = new Button();
            btnKlienciEdytuj = new Button();
            btnKlienciDodaj = new Button();
            dgvKlienci = new DataGridView();
            tabPage3 = new TabPage();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            costam.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlota).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKlienci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // costam
            // 
            costam.Controls.Add(tabPage1);
            costam.Controls.Add(tabPage2);
            costam.Controls.Add(tabPage3);
            costam.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            costam.Location = new Point(12, 123);
            costam.Name = "costam";
            costam.SelectedIndex = 0;
            costam.Size = new Size(1090, 545);
            costam.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUsun);
            tabPage1.Controls.Add(btnEdytuj);
            tabPage1.Controls.Add(btnDodaj);
            tabPage1.Controls.Add(dgvFlota);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1082, 507);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Flota";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(844, 460);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(79, 32);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Location = new Point(764, 460);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(74, 36);
            btnEdytuj.TabIndex = 2;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(666, 460);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(92, 32);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvFlota
            // 
            dgvFlota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFlota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlota.Location = new Point(6, 16);
            dgvFlota.Name = "dgvFlota";
            dgvFlota.ReadOnly = true;
            dgvFlota.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFlota.Size = new Size(1070, 427);
            dgvFlota.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnKlienciUsun);
            tabPage2.Controls.Add(btnKlienciEdytuj);
            tabPage2.Controls.Add(btnKlienciDodaj);
            tabPage2.Controls.Add(dgvKlienci);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1082, 507);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Klienci";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKlienciUsun
            // 
            btnKlienciUsun.Location = new Point(808, 465);
            btnKlienciUsun.Name = "btnKlienciUsun";
            btnKlienciUsun.Size = new Size(79, 34);
            btnKlienciUsun.TabIndex = 3;
            btnKlienciUsun.Text = "Usuń";
            btnKlienciUsun.UseVisualStyleBackColor = true;
            btnKlienciUsun.Click += btnKlienciUsun_Click;
            // 
            // btnKlienciEdytuj
            // 
            btnKlienciEdytuj.Location = new Point(711, 465);
            btnKlienciEdytuj.Name = "btnKlienciEdytuj";
            btnKlienciEdytuj.Size = new Size(82, 34);
            btnKlienciEdytuj.TabIndex = 2;
            btnKlienciEdytuj.Text = "Edytuj";
            btnKlienciEdytuj.UseVisualStyleBackColor = true;
            btnKlienciEdytuj.Click += btnKlienciEdytuj_Click;
            // 
            // btnKlienciDodaj
            // 
            btnKlienciDodaj.Location = new Point(607, 465);
            btnKlienciDodaj.Name = "btnKlienciDodaj";
            btnKlienciDodaj.Size = new Size(87, 34);
            btnKlienciDodaj.TabIndex = 1;
            btnKlienciDodaj.Text = "Dodaj";
            btnKlienciDodaj.UseVisualStyleBackColor = true;
            btnKlienciDodaj.Click += btnKlienciDodaj_Click;
            // 
            // dgvKlienci
            // 
            dgvKlienci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKlienci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlienci.Location = new Point(15, 27);
            dgvKlienci.Name = "dgvKlienci";
            dgvKlienci.Size = new Size(1053, 432);
            dgvKlienci.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1082, 507);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Wypożyczenia";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(431, 65);
            label1.TabIndex = 1;
            label1.Text = "WYPOŻYCZALNIA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rac_png;
            pictureBox1.Location = new Point(422, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 155);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(16, 683);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Wersja: 1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1114, 707);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(costam);
            Name = "Form1";
            Text = "Wypożyczalnia";
            costam.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlota).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKlienci).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private TabControl costam;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView dgvFlota;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private DataGridView dgvKlienci;
        private Button btnKlienciUsun;
        private Button btnKlienciEdytuj;
        private Button btnKlienciDodaj;
    }
}
