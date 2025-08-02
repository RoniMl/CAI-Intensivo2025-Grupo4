using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Materia
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public int horasSemanales { get; set; }
        public List<Materia> correlativas { get; set; } = new List<Materia>();        

    }
    
}
