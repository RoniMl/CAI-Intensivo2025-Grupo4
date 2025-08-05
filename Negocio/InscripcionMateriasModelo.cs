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
        private MateriaPersistencia materiaPersistencia = new MateriaPersistencia();
        private CursoPersistencia cursoPersistencia = new CursoPersistencia();
        private InscripcionPersistencia inscripcionPersistencia = new InscripcionPersistencia();
        private AlumnoPersistencia alumnoPersistencia = new AlumnoPersistencia();
        private CarreraPersistencia carreraPersistencia = new CarreraPersistencia();

        public InscripcionMateriasModelo()
        {
            materiaPersistencia = new MateriaPersistencia();
            inscripcionPersistencia = new InscripcionPersistencia();
            alumnoPersistencia = new AlumnoPersistencia();

        }        
        public List<CarreraResponse> ObtenerCarreras()
        {
            return carreraPersistencia.buscarCarrera();
        }
       
        public List<Materia> ObtenerMateriasPorCarrera(int carreraId)
        {
            return materiaPersistencia.buscarMateriasPorCarrera(carreraId);
        }

        public List<CursoResumenDTO> ObtenerCursosPorMateria(int id)
        {
            return cursoPersistencia.buscarCursosPorMateria(id);
        }


        public void InscribirAlumnoAMaterias(int alumnoId, List<int> materiasIds)
        {
            // Inscribir cada materia, no reasignar alumnoId ya que InscribirMaterias devuelve void
            foreach (int materiaId in materiasIds)
            {
                inscripcionPersistencia.InscribirMaterias(alumnoId, materiaId);
            }
            return;
        }

        public List<Materia> ObtenerMateriasHabilitadas(int alumnoId, int carreraId)
        {
            var todasLasMaterias = materiaPersistencia.buscarMateriasPorCarrera(carreraId);
            //Console.WriteLine("Materias de la carrera: " + todasLasMaterias.Count); //añadido utimo
            var materiasAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumnoId);

            var materiasHabilitadas = new List<Materia>();

            foreach (var materia in todasLasMaterias)
            {
                // Verificar si ya está aprobada
                bool yaAprobada = materiasAprobadas.Any(m => m.id == materia.id);
                if (yaAprobada)
                    continue;

                // Verificar que todas las correlativas estén aprobadas
                bool todasCorrelativasAprobadas = true;
                if (materia.correlativas != null && materia.correlativas.Count > 0)
                {
                    foreach (var correlativa in materia.correlativas)
                    {
                        bool correlativaAprobada = materiasAprobadas.Any(m => m.id == correlativa.id);
                        if (!correlativaAprobada)
                        {
                            todasCorrelativasAprobadas = false;
                            break;
                        }
                    }
                }

                if (todasCorrelativasAprobadas)
                {
                    materiasHabilitadas.Add(materia);
                }
            }

            return materiasHabilitadas;
        }

            //var idsAprobadas = materiasAprobadas.Select(m => (long)m.id).ToHashSet();
            //var habilitadas = todasLasMaterias
            //    .Where(m =>
            //        !idsAprobadas.Contains(m.id) &&   // no aprobadas
            //        (m.correlativas == null || m.correlativas.All(c => idsAprobadas.Contains(c.id))) // correlativas OK
            //    ).ToList();

            //return habilitadas;
        
        public double calcularRanking(int idAlumno)
        {
            int valorFaltante = 0;
            double? notasTotal = 0;

            List<Alumno> alumnos = alumnoPersistencia.buscarAlumnos();
            Alumno alumno = new Alumno();

            foreach (Alumno a in alumnos)
            {
                if (a.id == idAlumno)
                {
                    alumno = a;
                }
            }


            // Obtener todas las listas necesarias
            var materiasAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumno.id);
            var materiasAprobadasOFinal = alumnoPersistencia.ObtenerMateriasAprobadasOFinal(alumno.id);
            var materiasFaltantes = alumnoPersistencia.ObtenerMateriasNoAprobadas(alumno.id);

            // Corregir los contadores
            int cantidadMatsAprob = materiasAprobadas.Count;
            int cantidadMatsAprobOFin = materiasAprobadasOFinal.Count;
            int cantidadMatsNoAprob = materiasFaltantes.Count;

            // Detectar materias desaprobadas
            var materiasDesaprobadas = materiasFaltantes
                .Where(m => m.condicion == "DESAPROBADO")
                .ToList();

            // Sumar notas de desaprobadas
            foreach (var materia in materiasDesaprobadas)
            {
                notasTotal += materia.nota;
            }

            // Sumar notas de aprobadas
            foreach (var materia in materiasAprobadas)
            {
                notasTotal += materia.nota;
            }

            // Switch para puntaje adicional según materias faltantes
            switch (cantidadMatsNoAprob)
            {
                case 8: valorFaltante += 5; break;
                case 7: valorFaltante += 10; break;
                case 6: valorFaltante += 15; break;
                case 5: valorFaltante += 20; break;
                case 4: valorFaltante += 30; break;
                case 3: valorFaltante += 45; break;
                case 2: valorFaltante += 60; break;
                case 1: valorFaltante += 90; break;
            }

            double totalMateriasParaPromedio = cantidadMatsAprob + materiasDesaprobadas.Count;

            double promedio = (totalMateriasParaPromedio > 0)
                ? (double)(notasTotal / totalMateriasParaPromedio)
                : 0;

            double ranking = cantidadMatsAprobOFin * 100
                        + cantidadMatsAprob * 3
                        + valorFaltante
                        + promedio * 3;

            return ranking;
        }

    }

}

