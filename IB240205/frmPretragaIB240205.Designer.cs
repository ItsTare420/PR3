namespace Studentska.WinApp.IB240205
{
    partial class frmPretragaIB240205
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
            cbStatus = new ComboBox();
            btnNovaPraksa = new Button();
            btnNovaKompanija = new Button();
            dgvPodaci = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StudentInfo = new DataGridViewTextBoxColumn();
            Kompanija = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            StatusZahtjeva = new DataGridViewTextBoxColumn();
            DatumPromjeneStatusa = new DataGridViewTextBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            btnPrint = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 56);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(382, 23);
            txtPretraga.TabIndex = 0;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "REALIZOVANA" });
            cbStatus.Location = new Point(400, 56);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(138, 23);
            cbStatus.TabIndex = 1;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // btnNovaPraksa
            // 
            btnNovaPraksa.Location = new Point(808, 50);
            btnNovaPraksa.Name = "btnNovaPraksa";
            btnNovaPraksa.Size = new Size(97, 33);
            btnNovaPraksa.TabIndex = 2;
            btnNovaPraksa.Text = "Nova praksa";
            btnNovaPraksa.UseVisualStyleBackColor = true;
            btnNovaPraksa.Click += btnNovaPraksa_Click;
            // 
            // btnNovaKompanija
            // 
            btnNovaKompanija.Location = new Point(687, 50);
            btnNovaKompanija.Name = "btnNovaKompanija";
            btnNovaKompanija.Size = new Size(115, 33);
            btnNovaKompanija.TabIndex = 2;
            btnNovaKompanija.Text = "Nova kompanija";
            btnNovaKompanija.UseVisualStyleBackColor = true;
            btnNovaKompanija.Click += btnNovaKompanija_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Id, StudentInfo, Kompanija, Grad, StatusZahtjeva, DatumPromjeneStatusa, btnObrisi });
            dgvPodaci.Location = new Point(12, 85);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.Size = new Size(893, 302);
            dgvPodaci.TabIndex = 3;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
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
            // Kompanija
            // 
            Kompanija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kompanija.DataPropertyName = "Kompanija";
            Kompanija.HeaderText = "Kompanija";
            Kompanija.Name = "Kompanija";
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.Name = "Grad";
            // 
            // StatusZahtjeva
            // 
            StatusZahtjeva.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusZahtjeva.DataPropertyName = "StatusZahtjeva";
            StatusZahtjeva.HeaderText = "Status zahtjeva";
            StatusZahtjeva.Name = "StatusZahtjeva";
            // 
            // DatumPromjeneStatusa
            // 
            DatumPromjeneStatusa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPromjeneStatusa.DataPropertyName = "DatumPromjeneStatusa";
            DatumPromjeneStatusa.HeaderText = "Datum promjene";
            DatumPromjeneStatusa.Name = "DatumPromjeneStatusa";
            // 
            // btnObrisi
            // 
            btnObrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnObrisi.DataPropertyName = "btnObrisi";
            btnObrisi.HeaderText = "";
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Text = "Obriši";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(808, 393);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(97, 33);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 4;
            label1.Text = "Ime i prezime ili naziv kompanije:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Status zahtjeva:";
            // 
            // frmPretragaIB240205
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 438);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNovaKompanija);
            Controls.Add(btnPrint);
            Controls.Add(btnNovaPraksa);
            Controls.Add(cbStatus);
            Controls.Add(txtPretraga);
            Name = "frmPretragaIB240205";
            Text = "Pretraga";
            Load += frmPretragaIB240205_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPretraga;
        private ComboBox cbStatus;
        private Button btnNovaPraksa;
        private Button btnNovaKompanija;
        private DataGridView dgvPodaci;
        private Button btnPrint;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StudentInfo;
        private DataGridViewTextBoxColumn Kompanija;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn StatusZahtjeva;
        private DataGridViewTextBoxColumn DatumPromjeneStatusa;
        private DataGridViewButtonColumn btnObrisi;
    }
}