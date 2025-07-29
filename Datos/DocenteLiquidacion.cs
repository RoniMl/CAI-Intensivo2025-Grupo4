using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DocenteLiquidacion
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cuit  { get; set; }
        public int horasTotales { get; set; }
        public decimal sueldo { get; set; }
        public string mensajeError { get; set; }
    }
}
