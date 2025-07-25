using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InscripcionFinalesModelo
    {
        private AlumnoPersistencia _alumnoPersistencia = new AlumnoPersistencia();
        private InscripcionPersistencia _inscripcionPersistencia = new InscripcionPersistencia();

        public List<InscripcionMateriaResponse> ObtenerMateriasParaFinal(long alumnoId)
        {
            var materias = _alumnoPersistencia.ObtenerMateriasDelAlumno(alumnoId);

            return materias
                .Where(m => m.condicion == "REGULAR" || m.condicion == "FINAL")
                .ToList();
        }

        public void InscribirAFinal(long alumnoId, long materiaId)
        {
            _inscripcionPersistencia.InscribirAFinal(alumnoId, materiaId);
        }
    }

}
