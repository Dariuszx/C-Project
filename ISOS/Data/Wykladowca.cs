using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ISOS.Data
{
    public class Wykladowca
    {
        public User user;
        public ArrayList konsultacje;

        public Wykladowca(User u)
        {
            user = u;
        }

        public Konsultacje getKonsultacje(String przedmiotId)
        {
            foreach (Konsultacje k in konsultacje)
            {
                if (k.przedmiot.id.Equals(przedmiotId)) return k;
            }
            return null;
        }

        public void usunKonsultacje(String przedmiotId)
        {
            int index = 0;

            foreach (Konsultacje k in konsultacje)
            {
                if (k.przedmiot.Equals(przedmiotId)) konsultacje.RemoveAt(index); 
            }
            index++;
        }
    }
}
