﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InscripcionMateriaResponse
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string condicion { get; set; }
        public int nota { get; set; }

    }
    // Para inscribir materias (POST) no hace falta clase, es un List<long> directamente.
}
