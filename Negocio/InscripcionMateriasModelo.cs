using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Negocio
{
    public class InscripcionMateriasModelo
    {
        private MateriaPersistencia materiaPersistencia;
        private InscripcionPersistencia inscripcionPersistencia;
        private AlumnoPersistencia alumnoPersistencia;


        public InscripcionMateriasModelo()
        {
            materiaPersistencia = new MateriaPersistencia();
            inscripcionPersistencia = new InscripcionPersistencia();
            alumnoPersistencia = new AlumnoPersistencia();

        }

        public List<Materia> ObtenerMateriasPorCarrera(long carreraId)
        {
            return materiaPersistencia.buscarMateriasPorCarrera(carreraId);
        }

        public void InscribirAlumnoAMaterias(long alumnoId, List<long> materiasIds)
        {
            inscripcionPersistencia.InscribirMaterias(alumnoId, materiasIds);
        }
        public List<Materia> ObtenerMateriasHabilitadas(long alumnoId, long carreraId)
        {
            var todas = materiaPersistencia.buscarMateriasPorCarrera(carreraId);
            var aprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumnoId);
            var idsAprobadas = aprobadas.Select(m => (long)m.id).ToHashSet();

            var habilitadas = todas
                .Where(m =>
                    !idsAprobadas.Contains(m.Id) &&
                    (m.Correlativas == null || m.Correlativas.All(c => idsAprobadas.Contains(c.id)))
                ).ToList();

            return habilitadas;
        }

    }
}

