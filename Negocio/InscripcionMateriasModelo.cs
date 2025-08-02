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
        //public static List<int> ObtenerTodasCorrelativas(Materia materia)
        //{
        //    var materiasRecorridas = new List<int>();
        //    RecorrerCorrelativas(materia, materiasRecorridas);
        //    return materiasRecorridas;
        //}

        //private static void RecorrerCorrelativas(Materia materia, List<int> materiasRecorridas)
        //{
        //    if (materia == null || materiasRecorridas.Contains(materia.id))
        //        return;

        //    materiasRecorridas.Add(materia.id);

        //    if (materia.correlativas != null)
        //    {
        //        foreach (var correlativa in materia.correlativas)
        //        {
        //            RecorrerCorrelativas(correlativa, materiasRecorridas);
        //        }
        //    }
        //}
        //public List<Materia> ObtenerMateriasHabilitadas(int alumnoId, int carreraId)
        //{
        //    var todasMaterias = materiaPersistencia.buscarMateriasPorCarrera(carreraId);
        //    var aprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumnoId);

        //    // Lista de ids aprobados para verificar correlativas
        //    List<int> idsAprobadas = new List<int>();
        //    foreach (var m in aprobadas)
        //    {
        //        idsAprobadas.Add(m.id);
        //    }

        //    var habilitadas = new List<Materia>();
        //    foreach (var materia in todasMaterias)
        //    {
        //        if (idsAprobadas.Contains(materia.id))
        //        {
        //            // Si ya aprobó la materia, no la habilitamos para inscripción
        //            continue;
        //        }

        //        // Si no tiene correlativas, habilitada directamente
        //        if (materia.correlativas == null || materia.correlativas.Count == 0)
        //        {
        //            habilitadas.Add(materia);
        //            continue;
        //        }

        //        // Verifico que todas las correlativas estén aprobadas
        //        bool todasCorrelativasAprobadas = true;
        //        foreach (var correlativa in materia.correlativas)
        //        {
        //            if (!idsAprobadas.Contains(correlativa.id))
        //            {
        //                todasCorrelativasAprobadas = false;
        //                break;
        //            }
        //        }

        //        if (todasCorrelativasAprobadas)
        //        {
        //            habilitadas.Add(materia);
        //        }
        //    }

        //    return habilitadas;
        //}

        public List<Materia> ObtenerMateriasPorCarrera(int carreraId)
        {
            return materiaPersistencia.buscarMateriasPorCarrera(carreraId);
        }

        public void InscribirAlumnoAMaterias(int alumnoId, int materiasIds)
        {
            // convertir
            inscripcionPersistencia.InscribirMaterias(alumnoId, materiasIds);
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
        

        public int calcularRanking(int idAlumno)
        {
            int valorFaltante = 0;
            int? notasTotal = 0;

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

            int totalMateriasParaPromedio = cantidadMatsAprob + materiasDesaprobadas.Count;

            int promedio = (totalMateriasParaPromedio > 0)
                ? (int)(notasTotal / totalMateriasParaPromedio)
                : 0;

            int ranking = cantidadMatsAprobOFin * 100
                        + cantidadMatsAprob * 3
                        + valorFaltante
                        + promedio * 3;

            return ranking;
        }

    }

}

