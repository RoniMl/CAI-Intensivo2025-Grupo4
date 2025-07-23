using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LoginRequest
    {
        String _user;
        String _password;

        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
