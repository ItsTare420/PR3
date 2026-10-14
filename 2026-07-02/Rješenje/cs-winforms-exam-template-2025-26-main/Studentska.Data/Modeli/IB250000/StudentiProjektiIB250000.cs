using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB250000
{
    public class StudentiProjektiIB250000
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ProjekatId { get; set; }
        public ProjektiIB250000 Projekat{ get; set; }

        public DateTime DatumPrijave { get; set; }
        public string StatusPrijave { get; set; }
        public DateTime? DatumPromjeneStatusa { get; set; }
        public bool Arhivirana { get; set; }
    }
}
