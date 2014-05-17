using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISOS.Data;
using System.Collections;

namespace ISOS.Modules
{
    public class ModulBazaDanych
    {
        public ArrayList users;
        public ArrayList students;
        public ArrayList przedmioty;
        public ArrayList wykladowcy;
        public ArrayList konsultacje;

        public ModulBazaDanych()
        {
            users = new ArrayList();
            students = new ArrayList();
            przedmioty = new ArrayList();
            wykladowcy = new ArrayList();
            konsultacje = new ArrayList();
        }

        public User getUser(String nick)
        {
            foreach (User u in users)
            {
                if (u.nickname.Equals(nick)) return u;
            }
            return null;
        }

        public User getUser(String nick, String password)
        {
            foreach (User u in users)
            {
                if (u.nickname.Equals(nick) && u.password.Equals(password))
                {
                    return u;
                }
            }
            return null;
        }

        public Student getStudent(String nick)
        {
            foreach(Student s in students) {
                if (s.user.nickname.Equals(nick)) return s;
            }

            return null;
        }

        public Wykladowca getWykladowca(int index)
        {
            int i = 0;

            foreach (Wykladowca w in wykladowcy)
            {
                if (index == i) return w;
                i++;
            }

            return null;
        }

        public Wykladowca getWykladowca(String nick)
        {
            foreach (Wykladowca w in wykladowcy)
            {
                if (w.user.nickname.Equals(nick)) return w;
            }
            return null;
        }

        public int getWykladowcaIndex(String wykladowcaNick)
        {
            int index = 0;

            foreach (Wykladowca w in wykladowcy)
            {
                if (w.getNickname().Equals(wykladowcaNick)) return index;
                index++;
            }
            return -1;
        } 

        public ArrayList getWykladowcy()
        {
            return wykladowcy;
        }

        public Przedmiot getPrzedmiot(String przedmiotId)
        {
            foreach (Przedmiot p in przedmioty)
            {
                if (p.id.Equals(przedmiotId)) return p;
            }
            return null;
        }

        public Przedmiot getPrzedmiot(int index)
        {
            int i = 0;

            foreach (Przedmiot k in przedmioty)
            {
                if (i == index) return k;
                i++;
            }
            return null;
        }

        public Konsultacje getKonsultacje(String przedmiotId)
        {
            return getPrzedmiot(przedmiotId).wykladowca.getKonsultacje(przedmiotId);
        }

        public ArrayList getKonsultacjArrayList(String wykladowcaNick)
        {
            return getWykladowca(wykladowcaNick).konsultacje;
        }

        public void addUser(User u) {
           users.Add(u);
       }

        public void addStudent(User u)
        {
            students.Add(new Student(u));
        }

        public void addWykladowca(User u)
        {
            wykladowcy.Add(new Wykladowca(u));
        }

        public void addPrzedmiot(String wykladowcaNick, String nazwa, String id)
        {
            foreach (Wykladowca w in wykladowcy)
            {
                if (w.user.nickname.Equals(wykladowcaNick))
                {
                    przedmioty.Add(new Przedmiot(w, nazwa, id));
                    break;
                }
            }
        }

        public void usunWykladowce(String nickname)
        {
            ArrayList listaPrzedmiotowString = new ArrayList();

            foreach (Przedmiot p in przedmioty)
            {
                if (p.getWykladowcaNickname().Equals(nickname)) listaPrzedmiotowString.Add(p.id); 
            }

            foreach (String id in listaPrzedmiotowString )
            {
                usunPrzedmiot(id);
            }

            int index = 0;

            foreach (Wykladowca w in wykladowcy)
            {
                if( w.getNickname().Equals(nickname)) break;
                index++;
            }

            wykladowcy.RemoveAt(index);
            usunUser(nickname);

        }

        public void usunPrzedmiot(String przedmiotid)
        {
            foreach (Student s in students)
            {
                if (s.getPrzedmiotZapisany(przedmiotid) != null)
                {
                    s.wypiszZPrzedmiotu(przedmiotid); 
                }

                if (s.getKonsultacjeZapisany(przedmiotid) != null)
                {
                    s.wypiszZKonsultacji(przedmiotid);
                } 
            }

            getPrzedmiot(przedmiotid).wykladowca.usunKonsultacje(przedmiotid);

            int index = 0;

            foreach (Przedmiot p in przedmioty)
            {
                if (p.id.Equals(przedmiotid)) break;
                index++;
            }

            przedmioty.RemoveAt(index);
        }

        public void usunStudenta(String nick)
        {
            int index = 0;
            foreach (Student s in students)
            {
                if (s.user.nickname.Equals(nick)) students.RemoveAt(index);
                index++;
            }
        }

        public void usunUser(String nick)
        {
            int index = 0;

            foreach (User u in users)
            {
                if (u.nickname.Equals(nick)) break;
                index++;
            }

            users.RemoveAt(index);
        }

        public void studentZapiszNaPrzedmiot(String nick, String przedmiotId)
        {
            getStudent(nick).przedmiotyZapisane.Add(getPrzedmiot(przedmiotId));
            getStudent(nick).oceny.Add(new DziennikOcen(przedmiotId));
        }

        public void studentWypiszZPrzedmiotu(String nick, String przedmiotId)
        {
            getStudent(nick).wypiszZPrzedmiotu(przedmiotId);
            getStudent(nick).usunDziennikOcen(przedmiotId);
        }

        public void studentZapiszNaKonsultacje(String nick, String wykladowcaNick, String przedmiotId)
        {
            getStudent(nick).konsultacjeZapisane.Add(getWykladowca(wykladowcaNick).getKonsultacje(przedmiotId));
        }

        public void studentWypiszZKonsultacji(String nick, String przedmiotId)
        {
            getStudent(nick).wypiszZKonsultacji(przedmiotId);
        }

        public Konsultacje studentGetKonsultacjeZapisane(String nick, String przedmiotId)
        {
            return getStudent(nick).getKonsultacjeZapisany(przedmiotId);
        }
    }
}
