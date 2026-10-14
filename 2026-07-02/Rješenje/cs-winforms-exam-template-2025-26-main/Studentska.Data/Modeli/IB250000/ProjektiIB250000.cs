using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB250000
{
    public class ProjektiIB250000
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public byte[]? Logo { get; set; }
        public DateTime RokZavrsetka { get; set; }
        public int MaksStudenata { get; set; }
        public bool Aktivan { get; set; }
        public string? Napomena { get; set; }

    }
}
