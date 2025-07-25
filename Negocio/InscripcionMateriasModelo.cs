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
            Console.WriteLine("Materias de la carrera: " + todas.Count); //añadido utimo

            var aprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumnoId);
            var idsAprobadas = aprobadas.Select(m => (long)m.id).ToHashSet();

            //ultimo añadido
            Console.WriteLine("Materias aprobadas: " + idsAprobadas.Count);
            foreach (var id in idsAprobadas)
            {
                Console.WriteLine($"→ Aprobada ID: {id}");
            }

            var habilitadas = todas
                .Where(m =>
                    !idsAprobadas.Contains(m.id) &&   // no aprobadas
                    (m.correlativas == null || m.correlativas.All(c => idsAprobadas.Contains(c.id))) // correlativas OK
                ).ToList();

            //ultimo añadido
            Console.WriteLine("Materias habilitadas para mostrar: " + habilitadas.Count);
            foreach (var h in habilitadas)
            {
                Console.WriteLine($"→ Habilitada: {h.nombre}");
            }

            return habilitadas;
        }

    }
}

