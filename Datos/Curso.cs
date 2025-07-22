using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Curso
    {
        public int id { get; set; }
        public List<Docente> docentes { get; set; } = new List<Docente>();
        public List<Horario> horarios { get; set; } = new List<Horario>();
        public  Materia materia { get; set; } = new Materia();  

    }
}
