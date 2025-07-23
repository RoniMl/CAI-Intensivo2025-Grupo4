using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LoginRequest
    {
        private string _user;
        private string _password;

        public string user { get => _user; set => _user = value; }
        public string password { get => _password; set => _password = value; }
    }
}
