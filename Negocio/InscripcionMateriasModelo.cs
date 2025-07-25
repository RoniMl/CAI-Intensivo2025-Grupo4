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
            var materiasIdsInt = materiasIds.Select(id => (int)id).ToList(); // convertir
            inscripcionPersistencia.InscribirMaterias(alumnoId, materiasIdsInt);
        }

        //PRUEBA
        public List<Materia> ObtenerMateriasHabilitadas(long alumnoId, long carreraId)
        {
            var todasLasMaterias = materiaPersistencia.buscarMateriasPorCarrera(carreraId);
            var materiasAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumnoId);

            // Convertimos a HashSet por eficiencia
            var idsAprobadas = materiasAprobadas.Select(m => m.id).ToHashSet();

            var materiasHabilitadas = todasLasMaterias
                .Where(m =>
                    // No esté aprobada
                    !idsAprobadas.Contains(m.id) &&
                    // Todas sus correlativas estén aprobadas (o no tenga correlativas)
                    (m.correlativas == null || m.correlativas.All(c => idsAprobadas.Contains(c.id)))
                )
                .ToList();

            // Debug opcional para consola Output
            Console.WriteLine("Materias habilitadas para el alumno:");
            foreach (var m in materiasHabilitadas)
                Console.WriteLine($"✓ {m.nombre} (ID: {m.id})");

            return materiasHabilitadas;
        }


        /*LO QUE VA
        public List<Materia> ObtenerMateriasHabilitadas(long alumnoId, long carreraId)
        {
            var todas = materiaPersistencia.buscarMateriasPorCarrera(carreraId);
            Console.WriteLine("Materias de la carrera: " + todas.Count); //añadido utimo

            var aprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumnoId);
            var idsAprobadas = aprobadas.Select(m => (long)m.id).ToHashSet();
            var habilitadas = todas
                .Where(m =>
                    !idsAprobadas.Contains(m.id) &&   // no aprobadas
                    (m.correlativas == null || m.correlativas.All(c => idsAprobadas.Contains(c.id))) // correlativas OK
                ).ToList();

            return habilitadas;
        }
        */

    }
}

