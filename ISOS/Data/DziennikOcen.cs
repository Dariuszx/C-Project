using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ISOS.Data
{
    public class DziennikOcen
    {
        public ArrayList oceny;
        public String przedmiotId;

        public DziennikOcen(String p)
        {
            przedmiotId = p;
        }
    }
}
