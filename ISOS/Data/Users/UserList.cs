using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Data.Users
{
    public class UserList
    {
        public User[] users = 
            { 
                new User( "dybkad", "haslo", "student" ), 
                new User( "admin", "haslo", "dziekan" )
            };

        public UserList()
        {
        }

        public bool existUserPreference(User preferences)
        {
            foreach (User e in users)
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
