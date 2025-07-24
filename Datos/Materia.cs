using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int HorasSemanales { get; set; }
        public List<InscripcionMateriaResponse> Correlativas { get; set; } = new List<InscripcionMateriaResponse>();
        public List<CarreraResponse> Carreras { get; set; } = new List<CarreraResponse>();


    }
    
}
