using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Data
{
    public class Konsultacje
    {
        public Przedmiot przedmiot;
        public String czasKonsultacji;

        public Konsultacje(Przedmiot p, String czasKonsultacji)
        {
            this.czasKonsultacji = czasKonsultacji;
            this.przedmiot = p;
        }

        public String getPrzedmiotId()
        {
            return przedmiot.id;
        }
    }
}
