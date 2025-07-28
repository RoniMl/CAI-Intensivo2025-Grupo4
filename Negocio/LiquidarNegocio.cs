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
        public Docente? docenteEnLiquidacion;
        public CarreraPersistencia carreraPersistencia = new CarreraPersistencia();
        public CursoPersistencia cursoPersistencia = new CursoPersistencia();


        public List<CarreraResponse> ObtenerCarreras()
        {
            return carreraPersistencia.buscarCarrera();
        }

        //Obtener los cursos de todas las carreras
        
    }
}
