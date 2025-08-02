using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MenuAlumnoNegocio
    {
        private AlumnoPersistencia alumnoPersistencia = new AlumnoPersistencia();
        public Alumno ObtenerAlumnoPorId(int id)
        {            
            return alumnoPersistencia.BuscarAlumnoPorId(id);
        }
    }
}
