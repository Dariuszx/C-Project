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

        public User(String nickname, String password, String permissions)
        {
            this.nickname = nickname;
            this.password = password;
            this.permissions = permissions;
        }

        public User()
        {
        }

        public void clearData()
        {
            nickname = "";
            permissions = "";
            password = "";
        }
    }
}
