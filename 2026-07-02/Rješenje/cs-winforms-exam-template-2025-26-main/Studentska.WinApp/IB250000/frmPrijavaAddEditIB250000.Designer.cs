namespace Studentska.WinApp.IB250000
{
    partial class frmPrijavaAddEditIB250000
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
            cmbStudent = new ComboBox();
            cmbProjekat = new ComboBox();
            cmbStatus = new ComboBox();
            dtpDatumPrijave = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGenerisi = new Button();
            btnSacuvaj = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(24, 81);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(351, 23);
            cmbStudent.TabIndex = 0;
            // 
            // cmbProjekat
            // 
            cmbProjekat.FormattingEnabled = true;
            cmbProjekat.Location = new Point(394, 81);
            cmbProjekat.Name = "cmbProjekat";
            cmbProjekat.Size = new Size(351, 23);
            cmbProjekat.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbStatus.Location = new Point(394, 141);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(351, 23);
            cmbStatus.TabIndex = 0;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(24, 141);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(351, 23);
            dtpDatumPrijave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 63);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Projekat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 123);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Status prijave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 123);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 2;
            label4.Text = "DatumPrijave:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(24, 196);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(128, 38);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši prijave";
            btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(617, 196);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(128, 38);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 287);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(721, 206);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.Grip;
            label5.AutoSize = true;
            label5.Location = new Point(24, 269);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 269);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Generator info:";
            // 
            // frmPrijavaAddEditIB250000
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 515);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnGenerisi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cmbStatus);
            Controls.Add(cmbProjekat);
            Controls.Add(cmbStudent);
            Name = "frmPrijavaAddEditIB250000";
            Load += frmPrijavaAddEditIB250000_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbProjekat;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDatumPrijave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGenerisi;
        private Button btnSacuvaj;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
    }
}