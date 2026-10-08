using Studentska.Data.Modeli.IB240205;
using Studentska.Servis.Servisi;
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
    public partial class frmPraksaAddEditIB240205 : Form
    {
        private StudentiPraksaIB240205 _prijava;
        private StudentiPraksaServisIB240205 _studentiPraksaServis = new StudentiPraksaServisIB240205();
        private KompanijeServisIB240205 _kompanijeServis = new KompanijeServisIB240205();
        private StudentServis _studentServis = new StudentServis();

        public frmPraksaAddEditIB240205()
        {
            InitializeComponent();
            _prijava = null;
        }
        public frmPraksaAddEditIB240205(StudentiPraksaIB240205 prijava)
        {
            InitializeComponent();
            _prijava = prijava;
        }
        private void frmPraksaAddEditIB240205_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            UcitajKompanije();
            if (_prijava == null) // ADD MODE
            {
                cmbStatus.DataSource = new List<string> { "PODNESENA" };
                cmbStatus.SelectedIndex = 0;
                cmbStatus.Enabled = false;

            }
            else //EDIT MODE
            {
                cmbStudent.SelectedValue = Convert.ToInt32(_prijava.StudentId);
                cmbKompanija.SelectedValue = Convert.ToInt32(_prijava.KompanijaId);
                cmbStatus.SelectedItem = _prijava.StatusPrijave;
                dtpDatumPrijave.Value = _prijava.DatumPrijave;
            }
        }

        private void UcitajStudente()
        {
            var sviStudenti = _studentServis.GetAll();
            var cmbPodaci = sviStudenti.Select(s => new
            {
                Id = s.Id,
                Info = s.Info()
            }).ToList();
            cmbStudent.DataSource = cmbPodaci;
            cmbStudent.DisplayMember = "Info";
            cmbStudent.ValueMember = "Id";
        }
        private void UcitajKompanije()
        {
            var sveKompanije = _kompanijeServis.GetAll().Where(k => k.Aktivna);
            var cmbPodaci = sveKompanije.Select(k => new
            {
                Id = k.Id,
                Naziv = k.Naziv
            }).ToList();
            cmbKompanija.DataSource = cmbPodaci;
            cmbKompanija.DisplayMember = "Naziv";
            cmbKompanija.ValueMember = "Id";

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDatumPrijave.Value = DateTime.Now;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(cmbStatus.SelectedItem is null||
                cmbStudent.SelectedItem is null||
                cmbKompanija.SelectedItem is null)
            {
                MessageBox.Show("Molimo unesite sva polja prilikom spašavanja podataka!", "Greška"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int odabraniStudentId = Convert.ToInt32(cmbStudent.SelectedValue);
            int odabranaKompanijaId = Convert.ToInt32(cmbKompanija.SelectedValue);
            var odabranaKompanija = _kompanijeServis.GetById(odabranaKompanijaId);
            var odabraniStudent = _studentServis.GetById(odabraniStudentId);
            string odabraniStatus = cmbStatus.SelectedItem.ToString();
            int trenutnaPrijavaId = _prijava?.Id ?? 0;
            var svePrijave = _studentiPraksaServis.GetSve();
            if (odabraniStatus == "PRIHVACENA")
            {
                int trenutniBroj = svePrijave.Count(sp =>sp.Id!=trenutnaPrijavaId&& sp.KompanijaId == odabranaKompanijaId &&
                                    sp.StatusPrijave=="PRIHVACENA");
                if (trenutniBroj >= odabranaKompanija.MaksStudenata)
                {
                    MessageBox.Show("Broj prijava je prekoračen za odabranu kompaniju! Novi zahtjevi se mogu prihvatiti tek nakon što se za nekog od studenata koji su trenutno prihvaćeni promijeni status u REALIZOVANA", "Greška"
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            
            bool viseZahtjeva = svePrijave.Any(p => p.Id != trenutnaPrijavaId && p.StudentId == odabraniStudentId
            && p.KompanijaId == odabranaKompanijaId);
            if (viseZahtjeva)
            {
                MessageBox.Show("Student već ima podnesenu prijavu za odabranu kompaniju!", "Greška"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool visePrihvacenih = svePrijave.Any(p =>p.Id!=trenutnaPrijavaId&& p.StudentId == odabraniStudentId && p.StatusPrijave == "PRIHVACENA");
            if (visePrihvacenih)
            {
                MessageBox.Show("Student već ima jednu prihvaćenu praksu u drugoj kompaniji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_prijava == null)
            {
                var novaPrijava = new StudentiPraksaIB240205
                {
                    StudentId = odabraniStudentId,
                    KompanijaId = odabranaKompanijaId,
                    StatusPrijave = odabraniStatus,
                    DatumPrijave = dtpDatumPrijave.Value
                };
                _studentiPraksaServis.Add(novaPrijava);
                MessageBox.Show("Uspješno ste dodali novu prijavu!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _prijava.StudentId = odabraniStudentId;
                _prijava.KompanijaId = odabranaKompanijaId;
                _prijava.StatusPrijave = odabraniStatus;
                _prijava.DatumPrijave = dtpDatumPrijave.Value;
                if (_prijava.StatusPrijave != odabraniStatus)
                {
                    _prijava.DatumPromjeneStatusa = DateTime.Now;
                }
                _studentiPraksaServis.Update(_prijava);
                MessageBox.Show("Izmjene sačuvane!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
