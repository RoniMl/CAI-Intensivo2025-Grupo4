using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Alumno
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public List<int> carrerasId { get; set; } = new List<int>();
        public Usuario usuario { get; set; } = new Usuario(); //chequear

    }
}
