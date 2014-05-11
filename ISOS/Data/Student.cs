﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ISOS.Data
{
    public class Student
    {
        public User user;
        public ArrayList przedmiotyZapisane;
        public ArrayList konsultacjeZapisane;
        public ArrayList oceny;

        public Student(User u)
        {
            this.user = u;
        }

        public Przedmiot getPrzedmiotZapisany(String przedmiotid)
        {
            foreach (Przedmiot p in przedmiotyZapisane)
            {
                if (p.id.Equals(przedmiotid)) return p;
            }
            return null;
        }

        public Konsultacje getKonsultacjeZapisany(String przedmiotid)
        {
            foreach (Konsultacje k in konsultacjeZapisane)
            {
                if (k.przedmiot.id.Equals(przedmiotid)) return k;
            }
            return null;
        }

        public DziennikOcen getDziennikOcen(String przedmiotId)
        {
            foreach (DziennikOcen d in oceny)
            {
                if (d.przedmiotId.Equals(przedmiotId)) return d;
            }

            return null;
        }

        public void usunDziennikOcen(String przedmiotId)
        {
            int index = 0;
            foreach (DziennikOcen d in oceny)
            {
                if (d.przedmiotId.Equals(przedmiotId)) oceny.RemoveAt(index);
                index++;
            }
        }

        public void wypiszZPrzedmiotu(String przedmiotId)
        {
            int index = 0;
            foreach (Przedmiot p in przedmiotyZapisane)
            {
                if (p.id.Equals(przedmiotId)) przedmiotyZapisane.RemoveAt(index);
                    index++;
            }

        }

        public void wypiszZKonsultacji(String przedmiotId)
        {
            int index = 0;

            foreach (Konsultacje k in konsultacjeZapisane)
            {
                if (k.przedmiot.id.Equals(przedmiotId)) konsultacjeZapisane.RemoveAt(index);
                index++;
            }
        }


    }
}
