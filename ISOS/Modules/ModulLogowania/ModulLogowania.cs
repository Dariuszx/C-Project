using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISOS
{
    public class ModulLogowania
    {

        public bool isLoggedIn = false;
        private Data.Users.UserProperties accountPreferences;
        private Data.Users.UserList users;

        public ModulLogowania( Data.Users.UserList users, Data.Users.UserProperties accountPreferences)
        {
            this.users = users;
            this.accountPreferences = accountPreferences;
        }

        public String connect( String nickname, String password )
        {
            accountPreferences.nickname = nickname;
            accountPreferences.password = password;

            if (users.existUserPreference(accountPreferences) == false)
            {
                isLoggedIn = false;
                accountPreferences.clearData();
                return "Podana nazwa użytkownika lub hasło jest nieprawidłowe.";
            }
            else isLoggedIn = true;
            
            return null;
        }
    }

}
