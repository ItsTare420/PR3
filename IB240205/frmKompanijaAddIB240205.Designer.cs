namespace Studentska.WinApp.IB240205
{
    partial class frmKompanijaAddIB240205
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
            pbLogo = new PictureBox();
            txtNaziv = new TextBox();
            cmbGrad = new ComboBox();
            cbAktivna = new CheckBox();
            btnSacuvaj = new Button();
            txtURL = new TextBox();
            txtAdresa = new TextBox();
            txtMaksStudenata = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = SystemColors.AppWorkspace;
            pbLogo.Location = new Point(12, 41);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(175, 162);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(215, 51);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(277, 23);
            txtNaziv.TabIndex = 1;
            // 
            // cmbGrad
            // 
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(498, 51);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(270, 23);
            cmbGrad.TabIndex = 2;
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(498, 171);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(66, 19);
            cbAktivna.TabIndex = 3;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(661, 219);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(107, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(498, 109);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(270, 23);
            txtURL.TabIndex = 1;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(215, 109);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(277, 23);
            txtAdresa.TabIndex = 1;
            txtAdresa.TextChanged += textBox3_TextChanged;
            // 
            // txtMaksStudenata
            // 
            txtMaksStudenata.Location = new Point(215, 167);
            txtMaksStudenata.Name = "txtMaksStudenata";
            txtMaksStudenata.Size = new Size(277, 23);
            txtMaksStudenata.TabIndex = 1;
            txtMaksStudenata.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 33);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Grad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 91);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 91);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Adresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 149);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 5;
            label5.Text = "Maksimalno studenata:";
            // 
            // frmKompanijaAddIB240205
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 260);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivna);
            Controls.Add(cmbGrad);
            Controls.Add(txtURL);
            Controls.Add(txtMaksStudenata);
            Controls.Add(txtAdresa);
            Controls.Add(txtNaziv);
            Controls.Add(pbLogo);
            Name = "frmKompanijaAddIB240205";
            Text = "frmKompanijaAddIB240205";
            Load += frmKompanijaAddIB240205_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private TextBox txtNaziv;
        private ComboBox cmbGrad;
        private CheckBox cbAktivna;
        private Button btnSacuvaj;
        private TextBox txtURL;
        private TextBox txtAdresa;
        private TextBox txtMaksStudenata;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}