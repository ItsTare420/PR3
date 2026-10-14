using Studentska.Servis.Servisi.IB250000;
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
    public partial class frmPretragaIB250000 : Form
    {
        public StudentiProjektiServis _studentiProjektiServis = new StudentiProjektiServis();
        public frmPretragaIB250000()
        {
            InitializeComponent();
        }

        private void frmPretragaIB250000_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbStanje.SelectedIndex = 0;
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            string filterTekst = txtPretraga.Text.Trim().ToLower() ?? "";
            string odabraniStatus = cmbStatus.SelectedItem?.ToString() ?? "Sve";
            string odabranoStanje = cmbStanje.SelectedItem?.ToString() ?? "Sve";

            var filterPodaci = _studentiProjektiServis.GetSve().Where(sp =>
            (sp.Student.Ime.ToLower().Contains(filterTekst) ||
            sp.Student.Prezime.ToLower().Contains(filterTekst) ||
            sp.Projekat.Naziv.ToLower().Contains(filterTekst))
            &&
            (odabraniStatus == "Sve" || sp.StatusPrijave == odabraniStatus)
            &&
            (odabranoStanje == "Sve" ||
            (odabranoStanje == "Aktivna" && !sp.Arhivirana) ||
            (odabranoStanje == "Arhivirana" && sp.Arhivirana))).ToList();

            var noviPodaci = filterPodaci.Select(sp => new
            {
                Id = sp.Id,
                StudentInfo = sp.Student.Info(),
                Projekat = sp.Projekat.Naziv,
                RokZavrsetka = sp.Projekat.RokZavrsetka,
                StatusPrijave = sp.StatusPrijave,
                DatumPrijave = sp.DatumPrijave,
                DatumPromjeneStatusa = sp.DatumPromjeneStatusa,
                StanjePrijave = sp.Arhivirana ? "Arhivirana" : "Aktivna"
            }).ToList();

            dgvPodaci.DataSource = noviPodaci;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbStanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPodaci.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = Convert.ToInt32(dgvPodaci.Rows[e.RowIndex].Cells["Id"].Value);
                var prijava = _studentiProjektiServis.GetById(id);
                if (prijava != null)
                {
                    var poruka = MessageBox.Show("Da li ste sigurni da želite arhivirati ovu prijavu?",
                        "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (poruka == DialogResult.Yes)
                    {
                        prijava.Arhivirana = true;
                        _studentiProjektiServis.Update(prijava);
                        MessageBox.Show("Uspijeh!");
                        _studentiProjektiServis = new StudentiProjektiServis();
                        UcitajPodatke();
                    }
                    else return;
                }
            }

        }

        private void btnNovaPrijava_Click(object sender, EventArgs e)
        {
            var frmPrijavaAdd = new frmPrijavaAddEditIB250000();
            if (frmPrijavaAdd.ShowDialog() == DialogResult.OK)
            {
                _studentiProjektiServis = new StudentiProjektiServis();
                UcitajPodatke();
            }
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPodaci.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            {
                int id = Convert.ToInt32(dgvPodaci.Rows[e.RowIndex].Cells["Id"].Value);
                var prijava = _studentiProjektiServis.GetById(id);
                if (prijava != null)
                {
                    var frmPrijavaEdit = new frmPrijavaAddEditIB250000(prijava);
                    if (frmPrijavaEdit.ShowDialog() == DialogResult.OK)
                    {
                        _studentiProjektiServis = new StudentiProjektiServis();
                        UcitajPodatke();
                    }
                }
            }
        }

        private void btnNoviProjekat_Click(object sender, EventArgs e)
        {
            var frmProjekatAdd = new frmProjekatAddIB250000();
            if (frmProjekatAdd.ShowDialog() == DialogResult.OK)
            {
                _studentiProjektiServis = new StudentiProjektiServis();
                UcitajPodatke();
            }
        }
    }
}
