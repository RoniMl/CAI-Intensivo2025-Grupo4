﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class Docente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string cuit { get; set; }
        public string tipo  { get; set; } // Puede ser "Titular", "Adjunto", "JTP", etc.
    }
}
