using Studentska.Data.Modeli.IB240205;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IB240205;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IB240205
{
    public partial class frmKompanijaAddIB240205 : Form
    {
        private KompanijeServisIB240205 _kompanijeServis = new KompanijeServisIB240205();
        private GradServis _gradServis = new GradServis();
        public frmKompanijaAddIB240205()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKompanijaAddIB240205_Load(object sender, EventArgs e)
        {
            UcitajGradove();

        }
        private void UcitajGradove()
        {
            var sviGradovi = _gradServis.GetAll().Where(k => k.Aktivan).ToList();
            var cmbPodaci = sviGradovi.Select(g => new
            {
                Id = g.Id,
                Naziv = g.Naziv
            }).ToList();
            cmbGrad.DataSource = cmbPodaci;
            cmbGrad.ValueMember = "Id";
            cmbGrad.DisplayMember = "Naziv";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) ||
                string.IsNullOrWhiteSpace(txtAdresa.Text) ||
                string.IsNullOrWhiteSpace(txtURL.Text) ||
                string.IsNullOrWhiteSpace(txtMaksStudenata.Text) ||
                cmbGrad.SelectedValue == null ||
                pbLogo.Image == null)
            {
                MessageBox.Show("Molimo unesite sva polja (uključujući i logo) prilikom spašavanja nove kompanije!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string naziv = txtNaziv.Text.Trim();
            string adresa = txtAdresa.Text.Trim();
            string URL = txtURL.Text.Trim();
            string grad = cmbGrad.SelectedItem.ToString();
            int gradId = Convert.ToInt32(cmbGrad.SelectedValue);
            var logo = ImageHelper.ImageToByte(pbLogo.Image);
            if (!int.TryParse(txtMaksStudenata.Text, out int maksStudenata) || maksStudenata < 0)
            {
                MessageBox.Show("Maksimalan broj studenata ne može biti negativan!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sveKompanije = _kompanijeServis.GetAll();
            bool istoImeIGrad = sveKompanije.Any(k => k.Naziv.ToLower() == naziv.ToLower() && k.GradId == gradId);
            if (istoImeIGrad)
            {
                MessageBox.Show("Već postoji kompanija sa istim imenom u odabranom gradu!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidirajURL(URL))
            {
                MessageBox.Show("Uneseni URL nije u ispravnom formatu (www.xx.xx)!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var novaKompanija = new KompanijeIB240205 { 
                Naziv = naziv,
                GradId= gradId,
                Adresa = adresa,
                URL = URL,
                Slika = logo,
                MaksStudenata = maksStudenata,
                Aktivna = cbAktivna.Checked
            };
            _kompanijeServis.Add(novaKompanija);
            MessageBox.Show("Uspješno ste dodali novu kompaniju!", "Uspijeh",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool ValidirajURL(string URL)
        {
            string urlpattern = @"^www\.[a-zA-Z0-9]{2,}\.[a-zA-Z0-9]{2,}$";
            return Regex.IsMatch(URL, urlpattern);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pbLogo.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
