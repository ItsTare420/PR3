using Studentska.Data.Modeli.IB250000;
using Studentska.Servis.Servisi;
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
    public partial class frmPrijavaAddEditIB250000 : Form
    {
        private StudentiProjektiIB250000 _prijava;
        private StudentServis _studentServis = new StudentServis();
        private ProjektiServis _projektiServis = new ProjektiServis();
        private StudentiProjektiServis _studentiProjektiServis = new StudentiProjektiServis();
        public frmPrijavaAddEditIB250000()
        {
            InitializeComponent();
            _prijava = null;
        }
        public frmPrijavaAddEditIB250000(StudentiProjektiIB250000 prijava)
        {
            InitializeComponent();
            _prijava = prijava;
        }
        private void frmPrijavaAddEditIB250000_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            UcitajProjekte();
            if (_prijava == null)
            {
                this.Text = "Nova prijava na projekat";
                cmbStatus.SelectedItem = "PODNESENA";
                cmbStatus.Enabled = false;
            }
            else
            {
                this.Text = "Edit prijave na projekat";
                cmbStudent.SelectedValue = _prijava.StudentId;
                cmbStudent.Enabled = false;
                cmbStatus.SelectedItem = _prijava.StatusPrijave;
                if (_prijava.StatusPrijave != "PODNESENA")
                {
                    string[] statusi = { "PRIHVACENA", "ODBIJENA", "ZAVRSENA" };
                    cmbStatus.Items.Clear();
                    cmbStatus.Items.AddRange(statusi);

                }
            }
        }
        private void UcitajStudente()
        {
            var sviStudenti = _studentServis.GetAll().Where(s => s.Aktivan).ToList();
            var cmbPodaci = sviStudenti.Select(s => new
            {
                Id = s.Id,
                Info = s.Info()
            }).ToList();

            Ekstenzije.UcitajPodatke(cmbStudent, cmbPodaci, "Id", "Info");
        }
        private void UcitajProjekte()
        {
            var sviProjekti = _projektiServis.GetAll().Where(p => p.Aktivan).ToList();
            var cmbPodaci = sviProjekti.Select(p => new
            {
                Id = p.Id,
                Naziv = p.Naziv
            }).ToList();

            Ekstenzije.UcitajPodatke(cmbProjekat, cmbPodaci, "Id", "Naziv");
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDatumPrijave.Value = DateTime.Now;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            //4c
            if(cmbStudent.SelectedItem==null||cmbProjekat.SelectedItem==null||
                dtpDatumPrijave.Value == null || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Spašavanje podataka nije moguće - sva polja su obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //4d
            int projekatId =Convert.ToInt32( cmbProjekat.SelectedValue);
            ProjektiIB250000 odabraniProjekat = _projektiServis.GetById(projekatId);
            if (!odabraniProjekat.Aktivan)
            {
                MessageBox.Show("Dodavanje prijave za neaktivan projekat nije moguće!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //4e
            if (odabraniProjekat.RokZavrsetka.Date <= dtpDatumPrijave.Value.Date)
            {
                MessageBox.Show("Odabrani datum ne smije biti veći od roka završetka projekta",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //4f
            var sviStudenti = _studentServis.GetAll();
            var svePrijave = _studentiProjektiServis.GetAll();
            int odabraniStudentId = Convert.ToInt32(cmbStudent.SelectedValue);
            int odabraniProjekatId = Convert.ToInt32(cmbProjekat.SelectedValue);
            int prijavaId = _prijava?.Id ?? 0;
            bool dvijePrijave = svePrijave.Any(sp => sp.StudentId == odabraniStudentId && sp.Id != prijavaId 
            && sp.ProjekatId==odabraniProjekatId && !sp.Arhivirana);
            if (dvijePrijave)
            {
                MessageBox.Show("Student ima registrovanu već jednu prijavu na ovom projektu!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //4g
            var odabraniStatus = cmbStatus.SelectedItem?.ToString();
            if (odabraniStatus == "PRIHVACENA")
            {
                bool prihvacena = svePrijave.Any(sp => sp.StudentId == odabraniStudentId &&
                sp.StatusPrijave == "PRIHVACENA" && sp.Id != prijavaId);
                if (prihvacena)
                {
                    MessageBox.Show("Student već ima jednu prihvaćenu prijavu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //4h
            int brojPrijava = svePrijave.Count(sp => sp.ProjekatId == odabraniProjekatId && 
            sp.StatusPrijave=="PRIHVACENA"&&
            sp.Id!=prijavaId);
            if (brojPrijava > odabraniProjekat.MaksStudenata)
            {
                MessageBox.Show("Broj prihvaćenih prijava za projekat prelazi maksimalan broj studenata!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_prijava == null)
            {
                StudentiProjektiIB250000 novaPrijava = new StudentiProjektiIB250000
                {
                    StudentId = odabraniStudentId,
                    ProjekatId = odabraniProjekatId,
                    DatumPrijave = dtpDatumPrijave.Value,
                    StatusPrijave = "PODNESENA",
                    DatumPromjeneStatusa = null,
                    Arhivirana = false
                };
                _studentiProjektiServis.Add(novaPrijava);
                MessageBox.Show("Uspješno ste dodali novu prijavu!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _prijava.ProjekatId = odabraniProjekatId;
                bool promjenaStatusa = (_prijava.StatusPrijave != odabraniStatus);
                if (promjenaStatusa)
                {
                    _prijava.DatumPromjeneStatusa = dtpDatumPrijave.Value;
                    _prijava.StatusPrijave = odabraniStatus;
                }
                if (odabraniStatus == "ZAVRSENA")
                    _prijava.Arhivirana = true;
                _studentiProjektiServis.Update(_prijava);
                MessageBox.Show("Izmjene sačuvane!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
