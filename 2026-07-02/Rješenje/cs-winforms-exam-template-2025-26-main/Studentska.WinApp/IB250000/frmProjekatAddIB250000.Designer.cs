namespace Studentska.WinApp.IB250000
{
    partial class frmProjekatAddIB250000
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
            pbSlika = new PictureBox();
            txtNaziv = new TextBox();
            txtNapomena = new TextBox();
            dtpDatum = new DateTimePicker();
            txtMaksStudenata = new TextBox();
            cbAktivan = new CheckBox();
            btnSacuvaj = new Button();
            Logo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BackColor = SystemColors.AppWorkspace;
            pbSlika.Location = new Point(12, 56);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(190, 179);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(223, 56);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(500, 23);
            txtNaziv.TabIndex = 1;
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(223, 105);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(500, 73);
            txtNapomena.TabIndex = 1;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(223, 212);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(222, 23);
            dtpDatum.TabIndex = 2;
            // 
            // txtMaksStudenata
            // 
            txtMaksStudenata.Location = new Point(451, 212);
            txtMaksStudenata.Name = "txtMaksStudenata";
            txtMaksStudenata.Size = new Size(174, 23);
            txtMaksStudenata.TabIndex = 1;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(631, 212);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 3;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(606, 248);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(117, 30);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Location = new Point(12, 38);
            Logo.Name = "Logo";
            Logo.Size = new Size(37, 15);
            Logo.TabIndex = 5;
            Logo.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Naziv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 87);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Napomena:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 194);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 5;
            label4.Text = "Rok završetka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 194);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 5;
            label5.Text = "Maksimalno studenata:";
            // 
            // frmProjekatAddIB250000
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 290);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Logo);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivan);
            Controls.Add(dtpDatum);
            Controls.Add(txtNapomena);
            Controls.Add(txtMaksStudenata);
            Controls.Add(txtNaziv);
            Controls.Add(pbSlika);
            Name = "frmProjekatAddIB250000";
            Text = "frmProjekatAddIB250000";
            Load += frmProjekatAddIB250000_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private TextBox txtNaziv;
        private TextBox txtNapomena;
        private DateTimePicker dtpDatum;
        private TextBox txtMaksStudenata;
        private CheckBox cbAktivan;
        private Button btnSacuvaj;
        private Label Logo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}