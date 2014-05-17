using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISOS.Data;
using ISOS.Modules;

namespace ISOS
{
    public class Engine
    {
        public ModulLogowania loginModul; //Moduł logowania
        public ModulBazaDanych bazaDanych; //Baza użytkowników systemu

        public Engine()
        {
            bazaDanych = new ModulBazaDanych();
            loginModul = new ModulLogowania(bazaDanych); 

            //Wczytuje dane TODO podłączyć się do bazy danych!
            new Modules.ModulWczytywanieDanych(bazaDanych).wczytajStatyczneDane();
        }

        public String connect(String nick, String password)
        {
            return loginModul.connect(nick, password); 
        }

        public void logOut()
        {
            loginModul.logOut();
        }

        public bool modulLogowania()
        {
            Application.Run( new loginGui(this) );
            return loginModul.isLogged;
        }

        public void modulUzytkownika()
        {
            Application.Run(new GUI.mainUserPanel(this));
            loginModul.zalogowanyUzytkownik = null;
        }
    }
}
