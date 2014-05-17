using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Modules
{
    public class ModulWczytywanieDanych
    {
        public ModulBazaDanych bazaDanych;

        public ModulWczytywanieDanych(ModulBazaDanych b)
        {
            bazaDanych = b;
        }

        public void wczytajStatyczneDane()
        {
          
            bazaDanych.addUser(new Data.User("dariuszDybka", "haslo123", "student", "Dariusz", "Dybka", "marazmad.01@gmail.com"));
            bazaDanych.addStudent(bazaDanych.getUser("dariuszDybka"));

            bazaDanych.addUser(new Data.User("marazmad", "haslo", "dziekanat", "Jan", "Kowalski", "jkowal@ee.pw.edu.pl"));

            bazaDanych.addUser(new Data.User("dybkad", "haslo", "student", "Dariusz", "Dybka", "marazmad.01@gmail.com"));
            bazaDanych.addStudent(bazaDanych.getUser("dybkad"));

            bazaDanych.addUser(new Data.User("jstar", "haslo123", "wykladowca", "Jurek", "Starzyński", "jstar@ee.pw.edu.pl"));
            bazaDanych.addWykladowca(bazaDanych.getUser("jstar"));

            bazaDanych.addUser(new Data.User("jszostak", "haslo123", "wykladowca", "Jarosław", "Szostakowski", "jszostak@ee.pw.edu.pl"));
            bazaDanych.addWykladowca(bazaDanych.getUser("jszostak"));

            bazaDanych.addUser(new Data.User("jkowalski", "haslo123", "wykladowca", "Jan", "Kowalski", "jkowal@ee.pw.edu.pl"));
            bazaDanych.addWykladowca(bazaDanych.getUser("jkowalski"));

            bazaDanych.addPrzedmiot("jstar", "JiMP", "jimp");
            bazaDanych.addPrzedmiot("jszostak", "Teoria Obwodów i Sygnałów", "tois");
            bazaDanych.addPrzedmiot("jstar", "Podstawy Inżynierii Opr", "pio");
            bazaDanych.getStudent("dariuszDybka").zapiszNaPrzedmiot(bazaDanych.getPrzedmiot("jimp"));
            bazaDanych.getStudent("dybkad").zapiszNaPrzedmiot(bazaDanych.getPrzedmiot("tois"));

            bazaDanych.getWykladowca("jszostak").addKonsultacje(bazaDanych.getPrzedmiot("tois"), "jeszcze Kiedyś (:");
            bazaDanych.getWykladowca("jstar").addKonsultacje(bazaDanych.getPrzedmiot("jimp"), "Kiedyś (:");
            bazaDanych.getWykladowca("jstar").addKonsultacje(bazaDanych.getPrzedmiot("pio"), "Poniedziałek");

            bazaDanych.studentZapiszNaKonsultacje("dybkad", "jstar", "jimp");
            
        }
        
    }
}
