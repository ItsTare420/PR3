using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB250000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB250000
{
    public class StudentiProjektiServis:BaseServis<StudentiProjektiIB250000>
    {
        public List<StudentiProjektiIB250000> GetSve()
        {
            return _dbContext.Set<StudentiProjektiIB250000>()
                .Include(sp => sp.Student)
                .Include(sp => sp.Projekat).ToList();
        }
    }
}
