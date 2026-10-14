namespace Studentska.WinApp.IB250000
{
    partial class frmPretragaIB250000
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
            txtPretraga = new TextBox();
            cmbStatus = new ComboBox();
            dgvPodaci = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StudentInfo = new DataGridViewTextBoxColumn();
            Projekat = new DataGridViewTextBoxColumn();
            RokZavrsetka = new DataGridViewTextBoxColumn();
            StatusPrijave = new DataGridViewTextBoxColumn();
            DatumPrijave = new DataGridViewTextBoxColumn();
            DatumPromjeneStatusa = new DataGridViewTextBoxColumn();
            StanjePrijave = new DataGridViewTextBoxColumn();
            btnArhiviraj = new DataGridViewButtonColumn();
            label1 = new Label();
            cmbStanje = new ComboBox();
            btnNovaPrijava = new Button();
            btnNoviProjekat = new Button();
            btnPrint = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 38);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(320, 23);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += textBox1_TextChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Sve", "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbStatus.Location = new Point(338, 38);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(175, 23);
            cmbStatus.TabIndex = 1;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Id, StudentInfo, Projekat, RokZavrsetka, StatusPrijave, DatumPrijave, DatumPromjeneStatusa, StanjePrijave, btnArhiviraj });
            dgvPodaci.Location = new Point(12, 67);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.Size = new Size(983, 337);
            dgvPodaci.TabIndex = 3;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // StudentInfo
            // 
            StudentInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentInfo.DataPropertyName = "StudentInfo";
            StudentInfo.HeaderText = "Student";
            StudentInfo.Name = "StudentInfo";
            // 
            // Projekat
            // 
            Projekat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Projekat.DataPropertyName = "Projekat";
            Projekat.HeaderText = "Projekat";
            Projekat.Name = "Projekat";
            // 
            // RokZavrsetka
            // 
            RokZavrsetka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RokZavrsetka.DataPropertyName = "RokZavrsetka";
            RokZavrsetka.HeaderText = "Rok završetka";
            RokZavrsetka.Name = "RokZavrsetka";
            // 
            // StatusPrijave
            // 
            StatusPrijave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusPrijave.DataPropertyName = "StatusPrijave";
            StatusPrijave.HeaderText = "Status prijave";
            StatusPrijave.Name = "StatusPrijave";
            // 
            // DatumPrijave
            // 
            DatumPrijave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPrijave.DataPropertyName = "DatumPrijave";
            DatumPrijave.HeaderText = "Prijavljen";
            DatumPrijave.Name = "DatumPrijave";
            // 
            // DatumPromjeneStatusa
            // 
            DatumPromjeneStatusa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPromjeneStatusa.DataPropertyName = "DatumPromjeneStatusa";
            DatumPromjeneStatusa.HeaderText = "Promjena";
            DatumPromjeneStatusa.Name = "DatumPromjeneStatusa";
            // 
            // StanjePrijave
            // 
            StanjePrijave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StanjePrijave.DataPropertyName = "StanjePrijave";
            StanjePrijave.HeaderText = "Stanje prijave";
            StanjePrijave.Name = "StanjePrijave";
            // 
            // btnArhiviraj
            // 
            btnArhiviraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnArhiviraj.HeaderText = "";
            btnArhiviraj.Name = "btnArhiviraj";
            btnArhiviraj.Text = "Arhiviraj";
            btnArhiviraj.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 4;
            label1.Text = "Ime i prezime studenta ili naziv projekta:";
            // 
            // cmbStanje
            // 
            cmbStanje.FormattingEnabled = true;
            cmbStanje.Items.AddRange(new object[] { "Sve", "Aktivna", "Arhivirana" });
            cmbStanje.Location = new Point(519, 38);
            cmbStanje.Name = "cmbStanje";
            cmbStanje.Size = new Size(175, 23);
            cmbStanje.TabIndex = 1;
            cmbStanje.SelectedIndexChanged += cmbStanje_SelectedIndexChanged;
            // 
            // btnNovaPrijava
            // 
            btnNovaPrijava.Location = new Point(857, 33);
            btnNovaPrijava.Name = "btnNovaPrijava";
            btnNovaPrijava.Size = new Size(138, 31);
            btnNovaPrijava.TabIndex = 2;
            btnNovaPrijava.Text = "Nova prijava";
            btnNovaPrijava.UseVisualStyleBackColor = true;
            btnNovaPrijava.Click += btnNovaPrijava_Click;
            // 
            // btnNoviProjekat
            // 
            btnNoviProjekat.Location = new Point(713, 33);
            btnNoviProjekat.Name = "btnNoviProjekat";
            btnNoviProjekat.Size = new Size(138, 31);
            btnNoviProjekat.TabIndex = 2;
            btnNoviProjekat.Text = "Novi projekat";
            btnNoviProjekat.UseVisualStyleBackColor = true;
            btnNoviProjekat.Click += btnNoviProjekat_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(857, 410);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(138, 31);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 20);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 5;
            label2.Text = "Status prijave:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 20);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Stanje prijave:";
            // 
            // frmPretragaIB250000
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNoviProjekat);
            Controls.Add(btnPrint);
            Controls.Add(btnNovaPrijava);
            Controls.Add(cmbStanje);
            Controls.Add(cmbStatus);
            Controls.Add(txtPretraga);
            Name = "frmPretragaIB250000";
            Text = "Pretraga prijava na projekte";
            Load += frmPretragaIB250000_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        private ComboBox cmbStatus;
        private DataGridView dgvPodaci;
        private Label label1;
        private ComboBox cmbStanje;
        private Button btnNovaPrijava;
        private Button btnNoviProjekat;
        private Button btnPrint;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StudentInfo;
        private DataGridViewTextBoxColumn Projekat;
        private DataGridViewTextBoxColumn RokZavrsetka;
        private DataGridViewTextBoxColumn StatusPrijave;
        private DataGridViewTextBoxColumn DatumPrijave;
        private DataGridViewTextBoxColumn DatumPromjeneStatusa;
        private DataGridViewTextBoxColumn StanjePrijave;
        private DataGridViewButtonColumn btnArhiviraj;
    }
}