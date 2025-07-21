using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public string usuario { get; set; } = string.Empty;
        public string contraseña { get; set; } = string.Empty;
        public int intentosFallidos { get; set; } = 0;
        public bool bloqueado { get; set; } = false;
        public string perfilUsuario { get; set; } = string.Empty;

    }
}
