using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LoginResponse
    {
        private int _id;
        private String _perfilUsuario;

        public int id { get => _id; set => _id = value; }
        public string perfilUsuario { get => _perfilUsuario; set => _perfilUsuario = value; }
    }
}

