using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MenuPersonalNegocio
    {
        private DocentePersistencia docentePersistencia = new DocentePersistencia();

        public Docente ObtenerDocentePorId(int id)
        {
            return docentePersistencia.BuscarDocentePorId(id);
        }




    }
}
