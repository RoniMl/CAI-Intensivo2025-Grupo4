using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Docente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string cuit { get; set; }
        public int antiguedad { get; set; } // Años de antigüedad en la institución
        public string tipo { get; set; } // Puede ser "Profesor", "Ayudante" o "Ayudante ad honorem"       
        public List<int> cursos { get; set; } = new List<int>(); // Id cursos que imparte el docente

    }

    
}
