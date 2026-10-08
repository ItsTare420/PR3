using Studentska.Servis.Servisi.IB240205;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IB240205
{
    public partial class frmPretragaIB240205 : Form
    {
        private StudentiPraksaServisIB240205 _studentiPraksaServis = new StudentiPraksaServisIB240205();
        public frmPretragaIB240205()
        {
            InitializeComponent();
        }

        private void frmPretragaIB240205_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            cbStatus.SelectedIndex = 0;
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            string filterTekst = txtPretraga.Text?.Trim().ToLower() ?? "";
            string odabraniStatus = cbStatus.SelectedItem.ToString();

            var filterPodaci = _studentiPraksaServis.GetSve().Where(sp =>
            (sp.Student.Ime.ToLower().Contains(filterTekst) ||
            sp.Student.Prezime.ToLower().Contains(filterTekst) ||
            sp.Kompanija.Naziv.ToLower().Contains(filterTekst))
            &&
            (sp.StatusPrijave == odabraniStatus));

            var podaciGrid = filterPodaci.Select(sp => new
            {
                Id = sp.Id,
                StudentInfo = sp.Student.Info(),
                Kompanija = sp.Kompanija.Naziv,
                Grad = sp.Kompanija.Grad.Naziv,
                StatusZahtjeva = sp.StatusPrijave,
                DatumPromjeneStatusa = sp.DatumPromjeneStatusa
            }).ToList();

            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = podaciGrid;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPodaci.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = Convert.ToInt32(dgvPodaci.Rows[e.RowIndex].Cells["Id"].Value);
                var praksa = _studentiPraksaServis.GetById(id);
                if (praksa != null)
                {
                    var poruka = MessageBox.Show("Da li ste sigurni da želite obrisati ovu prijavu?",
                        "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (poruka == DialogResult.Yes)
                    {
                        _studentiPraksaServis.Remove(praksa);
                        MessageBox.Show("Uspjeh!");
                        _studentiPraksaServis = new StudentiPraksaServisIB240205();
                        UcitajPodatke();
                    }
                    else return;
                }
            }
            if (e.RowIndex >= 0 && dgvPodaci.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            {
                int id = Convert.ToInt32(dgvPodaci.Rows[e.RowIndex].Cells["Id"].Value);
                var praksa = _studentiPraksaServis.GetById(id);
                if (praksa != null)
                {
                    var frmPraksaEdit = new frmPraksaAddEditIB240205(praksa);
                    if (frmPraksaEdit.ShowDialog() == DialogResult.OK)
                    {
                        _studentiPraksaServis = new StudentiPraksaServisIB240205();
                        UcitajPodatke();
                    }
                }
            }
        }

        private void btnNovaKompanija_Click(object sender, EventArgs e)
        {
            var frmKompanijaAdd = new frmKompanijaAddIB240205();
            if (frmKompanijaAdd.ShowDialog() == DialogResult.OK)
            {
                _studentiPraksaServis = new StudentiPraksaServisIB240205();
                UcitajPodatke();
            }
        }

        private void btnNovaPraksa_Click(object sender, EventArgs e)
        {
            var frmPraksaAdd = new frmPraksaAddEditIB240205();
            if (frmPraksaAdd.ShowDialog() == DialogResult.OK)
            {
                _studentiPraksaServis = new StudentiPraksaServisIB240205();
                UcitajPodatke();
            }
        }
    }
}
