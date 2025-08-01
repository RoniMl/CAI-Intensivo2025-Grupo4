using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class GenerarReportesNegocio
    {
        AlumnoPersistencia alumnoPersistencia = new AlumnoPersistencia();
        CarreraPersistencia carreraPersistencia = new CarreraPersistencia();

        //public List<MateriaReporte> carrerasReporte()
        //{
        //    List<MateriaReporte> reportes = new List<MateriaReporte>();
        //    List<CarreraResponse> carreras = carreraPersistencia.buscarCarrera();

        //    foreach (var carrera in carreras)
        //    {
        //        MateriaReporte materiaReporte = new MateriaReporte();
        //        materiaReporte = materiaReportes(carrera);
        //       reportes.Add(materiaReporte);
        //    }

        //   return reportes;
        //}

        //public MateriaReporte materiaReportes(CarreraResponse carrera)
        //{
        //    List<Alumno> alumnos = alumnoPersistencia.buscarAlumnos();
        //    MateriaReporte materiaReporte = new MateriaReporte();

        //    string nombreCarrera = carrera.nombre;
        //    int cumLaude = 0;
        //    int summaCumLaude = 0;
        //    int magnumSummaCumLaude = 0;
        //    int totalEgresados = 0;

        //    foreach (var alumno in alumnos)
        //    {
        //        foreach (int carreraAlumno in alumno.carrerasIds)
        //        {
        //            if (carreraAlumno != carrera.id)
        //                continue; // Solo consideramos alumnos de la carrera actual
        //        }

        //        var materiasNoAprobadas = alumnoPersistencia.ObtenerMateriasNoAprobadas(alumno.id);
        //        if (materiasNoAprobadas.Count > 0)
        //            continue;

        //        // Ahora sí es egresado
        //        totalEgresados++;

        //        var materiasAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumno.id);
        //        if (materiasAprobadas.Count == 0)
        //            continue; // Por seguridad

        //        int sumaNotas = materiasAprobadas.Sum(m => m.nota ?? 0);
        //        int totalMaterias = materiasAprobadas.Count + materiasNoAprobadas.Count;
        //        decimal promedio = sumaNotas / totalMaterias;

        //        // Clasificación por promedio
        //        if (promedio >= 8 && promedio < 9)
        //        { 
        //            cumLaude++;
        //        }
                   
        //        else if (promedio >= 9 && promedio < 10)
        //        {

        //            summaCumLaude++;
        //        }
        //        else if (promedio == 10)
        //        {

        //            magnumSummaCumLaude++;
        //        }
            
        //    }


        //    return materiaReporte;
        //}

        public List<MateriaReporte> generarReportes()
        {
            List<MateriaReporte> reportes = new List<MateriaReporte>();
            List<CarreraResponse> carreras = carreraPersistencia.buscarCarrera();
            List<Alumno> alumnos = alumnoPersistencia.buscarAlumnos();

            foreach (var carrera in carreras)
            {
                // Filtrar alumnos de la carrera
                List<Alumno> alumnosDeLaCarrera = alumnos
                    .Where(a => a.carrerasIds.Contains(carrera.id))
                    .ToList();

                int cumLaude = 0;
                int summaCumLaude = 0;
                int magnumSummaCumLaude = 0;
                int totalEgresados = 0;

                foreach (var alumno in alumnosDeLaCarrera)
                {
                    var matsNoAprobadas = alumnoPersistencia.ObtenerMateriasNoAprobadas(alumno.id);
                    if (matsNoAprobadas.Count > 0)
                        continue; // no es egresado

                    var matsAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumno.id);
                    

                    totalEgresados++;

                    int totalNotas = matsAprobadas.Sum(m => m.nota ?? 0);
                    decimal promedio = (decimal)totalNotas / matsAprobadas.Count;

                    if (promedio >= 8 && promedio < 9)
                        cumLaude++;
                    else if (promedio >= 9 && promedio < 10)
                        summaCumLaude++;
                    else if (promedio == 10)
                        magnumSummaCumLaude++;
                }

                var materiaReporte = new MateriaReporte
                {
                    nombre = carrera.nombre,
                    totalEgresados = totalEgresados,
                    cumLaude = cumLaude,
                    summaCumLaude = summaCumLaude,
                    magnumSummaCumLaude = magnumSummaCumLaude
                };

                reportes.Add(materiaReporte);
            }

            return reportes;
        }



    }
}
