using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Data
{
    public class User
    {
        public String nickname;
        public String permissions;
        public String password;
        public String name;
        public String surname;
        public String email;

        public User(String nickname, String password, String permissions, String name, String surname, String email)
        {
            this.nickname = nickname;
            this.password = password;
            this.permissions = permissions;
            this.name = name;
            this.surname = surname;
            this.email = email;
        }

        public void clearData()
        {
            nickname = "";
            permissions = "";
            password = "";
        }
    }
}
