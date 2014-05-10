using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Data.Users
{
    public class UserList
    {
        public UserProperties[] users = 
            { 
                new UserProperties( "dybkad", "haslo", "student" ), 
                new UserProperties( "admin", "haslo", "dziekan" )
            };

        public UserList()
        {
           
        }

        public bool existUserPreference(UserProperties preferences)
        {
            foreach (UserProperties e in users)
            {
                if (e.nickname == preferences.nickname && e.password == preferences.password)
                {
                    preferences.permissions = e.permissions;
                    return true;
                } 
            }
            return false;
        }

        private void readUserList()
        {
            
        } //TODO
    }
}
