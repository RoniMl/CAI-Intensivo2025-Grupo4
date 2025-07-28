using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class LiquidarNegocio
    {
        Docente docenteEnLiquidacion = new Docente();

        public int LiquidarDocente(long idDocente)
        {
            docenteEnLiquidacion = new DocentePersistencia().BuscarDocentePorDni(idDocente.ToString()); 

            return;
        }

       
    }
}
