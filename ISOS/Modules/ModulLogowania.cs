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

        public String getNicknameUserLoggedIn()
        {
            return zalogowanyUzytkownik.nickname;
        }

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

        public bool isStudent()
        {
            if (zalogowanyUzytkownik.permissions.Equals("student")) return true;
            else return false;
        }

        public bool isDziekanat()
        {
            if (zalogowanyUzytkownik.permissions.Equals("dziekanat")) return true;
            else return false;
        }

        public bool isWykladowca()
        {
            if (zalogowanyUzytkownik.permissions.Equals("wykladowca")) return true;
            else return false;
        }

        public void logOut()
        {
            isLogged = false;
            zalogowanyUzytkownik = null;
        }
    }

}
