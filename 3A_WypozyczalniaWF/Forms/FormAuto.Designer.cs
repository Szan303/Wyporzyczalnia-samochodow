namespace _3A_WypozyczalniaWF.Forms
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
            txtMarka = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtModel = new TextBox();
            label4 = new Label();
            numRok = new NumericUpDown();
            numCena = new NumericUpDown();
            label5 = new Label();
            btnOK = new Button();
            cboTyp = new ComboBox();
            label1 = new Label();
            numParam = new NumericUpDown();
            lblParam = new Label();
            ((System.ComponentModel.ISupportInitialize)numRok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numParam).BeginInit();
            SuspendLayout();
            // 
            // txtMarka
            // 
            txtMarka.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtMarka.Location = new Point(12, 92);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(246, 33);
            txtMarka.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(264, 64);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 4;
            label3.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtModel.Location = new Point(264, 92);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(237, 33);
            txtModel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 6;
            label4.Text = "Rok";
            // 
            // numRok
            // 
            numRok.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numRok.Location = new Point(12, 169);
            numRok.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numRok.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numRok.Name = "numRok";
            numRok.Size = new Size(110, 33);
            numRok.TabIndex = 7;
            numRok.TextAlign = HorizontalAlignment.Center;
            numRok.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // numCena
            // 
            numCena.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numCena.Location = new Point(128, 169);
            numCena.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCena.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numCena.Name = "numCena";
            numCena.Size = new Size(140, 33);
            numCena.TabIndex = 9;
            numCena.TextAlign = HorizontalAlignment.Center;
            numCena.ThousandsSeparator = true;
            numCena.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(128, 141);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 8;
            label5.Text = "Cena za dzień";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnOK.Location = new Point(401, 236);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 46);
            btnOK.TabIndex = 10;
            btnOK.Text = "Zapisz";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cboTyp
            // 
            cboTyp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cboTyp.FormattingEnabled = true;
            cboTyp.Items.AddRange(new object[] { "OSOBOWY", "DOSTAWCZY", "SPORTOWY" });
            cboTyp.Location = new Point(274, 169);
            cboTyp.Name = "cboTyp";
            cboTyp.Size = new Size(227, 33);
            cboTyp.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(274, 141);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 12;
            label1.Text = "Typ";
            // 
            // numParam
            // 
            numParam.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numParam.Location = new Point(12, 249);
            numParam.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numParam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParam.Name = "numParam";
            numParam.Size = new Size(140, 33);
            numParam.TabIndex = 14;
            numParam.TextAlign = HorizontalAlignment.Center;
            numParam.ThousandsSeparator = true;
            numParam.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblParam
            // 
            lblParam.AutoSize = true;
            lblParam.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblParam.Location = new Point(12, 221);
            lblParam.Name = "lblParam";
            lblParam.Size = new Size(124, 25);
            lblParam.TabIndex = 13;
            lblParam.Text = "Liczba miejsc";
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 307);
            Controls.Add(numParam);
            Controls.Add(lblParam);
            Controls.Add(label1);
            Controls.Add(cboTyp);
            Controls.Add(btnOK);
            Controls.Add(numCena);
            Controls.Add(label5);
            Controls.Add(numRok);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(txtMarka);
            Name = "FormAuto";
            Text = "Dodaj/Edytuj auto";
            ((System.ComponentModel.ISupportInitialize)numRok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCena).EndInit();
            ((System.ComponentModel.ISupportInitialize)numParam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMarka;
        private Label label2;
        private Label label3;
        private TextBox txtModel;
        private Label label4;
        private NumericUpDown numRok;
        private NumericUpDown numCena;
        private Label label5;
        private Button btnOK;
        private ComboBox cboTyp;
        private Label label1;
        private NumericUpDown numParam;
        private Label lblParam;
    }
}