using Studentska.Data.Modeli.IB250000;
using Studentska.Servis.Servisi.IB250000;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IB250000
{
    public partial class frmProjekatAddIB250000 : Form
    {
        private ProjektiServis _projektiServis = new ProjektiServis();
        public frmProjekatAddIB250000()
        {
            InitializeComponent();
        }

        private void frmProjekatAddIB250000_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) ||
                string.IsNullOrWhiteSpace(txtMaksStudenata.Text) ||
                pbSlika.Image is null || dtpDatum.Value == null)
            {
                MessageBox.Show("Molimo unesite sva polja prilikom spašavanja podataka!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string uneseniNaziv = txtNaziv.Text.Trim();
            var sviProjekti = _projektiServis.GetAll();
            bool dupliNaziv = sviProjekti.Any(p => p.Naziv == uneseniNaziv);
            if (dupliNaziv)
            {
                MessageBox.Show("Dodavanje projekta sa duplim nazivom nije moguće!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDatum.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Datum završetka projekta ne smije biti manji od trenutnog datuma!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int uneseniBrojStudenata = Convert.ToInt32(txtMaksStudenata.Text);
            if (uneseniBrojStudenata < 1)
            {
                MessageBox.Show("Maksimalan broj studenata mora biti veći od 0!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var noviProjekat = new ProjektiIB250000 { 
                Naziv = uneseniNaziv,
                Logo=ImageHelper.ImageToByte(pbSlika.Image),
                RokZavrsetka=dtpDatum.Value,
                MaksStudenata=uneseniBrojStudenata,
                Aktivan=cbAktivan.Checked,
                Napomena=txtNapomena.Text
            };
            _projektiServis.Add(noviProjekat);
            MessageBox.Show("Uspješno ste dodali novi projekat!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
