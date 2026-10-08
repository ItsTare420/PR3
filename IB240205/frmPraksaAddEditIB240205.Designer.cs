namespace Studentska.WinApp.IB240205
{
    partial class frmPraksaAddEditIB240205
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
            cmbKompanija = new ComboBox();
            dtpDatumPrijave = new DateTimePicker();
            btnSacuvaj = new Button();
            txtInfo = new TextBox();
            label1 = new Label();
            cmbStudent = new ComboBox();
            cmbStatus = new ComboBox();
            btnGenerisi = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbKompanija
            // 
            cmbKompanija.FormattingEnabled = true;
            cmbKompanija.Location = new Point(384, 56);
            cmbKompanija.Name = "cmbKompanija";
            cmbKompanija.Size = new Size(366, 23);
            cmbKompanija.TabIndex = 0;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(12, 113);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(366, 23);
            dtpDatumPrijave.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(643, 162);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(104, 31);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(12, 261);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(735, 177);
            txtInfo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Student:";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 56);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(366, 23);
            cmbStudent.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbStatus.Location = new Point(384, 113);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(366, 23);
            cmbStatus.TabIndex = 0;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 224);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(735, 31);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generiši izjave";
            btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Kompanija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 95);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Datum prijave:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 4;
            label5.Text = "Generator info:";
            // 
            // frmPraksaAddEditIB240205
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInfo);
            Controls.Add(btnGenerisi);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cmbStudent);
            Controls.Add(cmbStatus);
            Controls.Add(cmbKompanija);
            Name = "frmPraksaAddEditIB240205";
            Text = "Praksa";
            Load += frmPraksaAddEditIB240205_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKompanija;
        private DateTimePicker dtpDatumPrijave;
        private Button btnSacuvaj;
        private TextBox txtInfo;
        private Label label1;
        private ComboBox cmbStudent;
        private ComboBox cmbStatus;
        private Button btnGenerisi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}