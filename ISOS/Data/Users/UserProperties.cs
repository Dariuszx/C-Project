using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISOS.Data.Users
{
    public class UserProperties
    {
        public String nickname;
        public String permissions;
        public String password;

        public UserProperties(String nickname, String password, String permissions)
        {
            this.nickname = nickname;
            this.password = password;
            this.permissions = permissions;
        }

        public UserProperties()
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
