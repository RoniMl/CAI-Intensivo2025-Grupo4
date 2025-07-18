using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Intensivo2025_Grupo4.Datos
{
    public class Usuario
    {
        public string usuario { get; set; } = string.Empty;
        public string contraseña { get; set; } = string.Empty;
        public int intentosFallidos { get; set; }
        public bool bloqueado { get; set; } = false;
        public int credenciales { get; set; } = 0;

    }
}
