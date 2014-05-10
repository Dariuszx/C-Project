using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOS
{
    public class Engine
    {
        public Data.Users.UserProperties accountPreferences; //Preference konta użytkownika
        public ModulLogowania login; //Moduł logowania
        public Data.Users.UserList users; //Lista wszystkich użytkowników

        public Engine()
        {
            accountPreferences = new Data.Users.UserProperties();
            users = new Data.Users.UserList();
            login = new ModulLogowania(users, accountPreferences);
        }

        public String connect(String nick, String password)
        {
            return login.connect(nick, password); 
        }

        public void logOut()
        {
            login.isLoggedIn = false;
            accountPreferences.clearData();
        }

        public bool modulLogowania()
        {
            Application.Run( new loginGui(this) );
            return login.isLoggedIn;
        }

        public void modulUzytkownika()
        {
            if (accountPreferences.permissions.Equals("student"))
            {
                Application.Run(new GUI.studentPanelGui( this ));
                accountPreferences.clearData();
            }
            else if (accountPreferences.permissions.Equals("dziekan"))
            {
                //TODO
            }
            else if (accountPreferences.permissions.Equals("panizdziekanatu"))
            {
                //TODO
            }
        }
    }
}
