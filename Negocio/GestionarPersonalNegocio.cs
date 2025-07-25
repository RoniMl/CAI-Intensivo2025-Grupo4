using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestionarPersonalNegocio
    {
        private DocentePersistencia docentePersistencia = new DocentePersistencia();

        public Docente ObtenerDocentePorDni(string dni)
        {
            return docentePersistencia.BuscarDocentePorDni(dni);
        }

        public bool EliminarDocentePorId(int id)
        {
            return docentePersistencia.EliminarDocente(id);
        }
    }
}
