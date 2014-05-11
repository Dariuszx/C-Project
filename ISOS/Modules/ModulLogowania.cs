using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISOS.Data;
using ISOS.Modules;

namespace ISOS
{
    public class ModulLogowania
    {

        public bool isLogged = false;

        public User zalogowanyUzytkownik;
        private ModulBazaDanych bazaDanych;

        public ModulLogowania( Modules.ModulBazaDanych bazaDanych )
        {
            this.bazaDanych = bazaDanych;
        }

        public String connect( String nickname, String password )
        {

            if ( (zalogowanyUzytkownik = bazaDanych.getUser(nickname,password)) == null)
            {
                isLogged = false;
                return "Podana nazwa użytkownika lub hasło jest nieprawidłowe.";
            }
            else isLogged = true;
            
            return null;
        }

        public void logOut()
        {
            isLogged = false;
            zalogowanyUzytkownik = null;
        }
    }

}
