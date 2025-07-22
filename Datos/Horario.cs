using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Horario
    {
        public string dia { get; set; } = string.Empty; // Lunes, Martes, etc.
        public string horaInicio { get; set; } = string.Empty; // Formato "HH:mm"
        public string horaFin { get; set; } = string.Empty; // Formato "HH:mm"
    }
}
