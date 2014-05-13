using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Data
{
    public class Przedmiot
    {
        public Wykladowca wykladowca;
        public String nazwa;
        public String id;
        public int limitMiejsc;

        public Przedmiot(Wykladowca w, String nazwa, String id)
        {
            wykladowca = w;
            this.nazwa = nazwa;
            this.id = id;
        }

        public String getWykladowcaNickname()
        {
            return wykladowca.getNickname();
        }
    }
}
