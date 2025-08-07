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
                    var matsAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumno.id);

                    if (matsNoAprobadas.Count > 0)
                        continue; // no es egresado

                    if (matsAprobadas.Count == 0 || matsAprobadas == null)
                        continue; 

                    totalEgresados++;

                    int totalNotas = matsAprobadas.Sum(m => m.nota ?? 0);
                    decimal promedio = (decimal)totalNotas / matsAprobadas.Count;

                    if (promedio >= 8 && promedio < 9)
                        cumLaude++;
                    else if (promedio >= 9 && promedio < 10)
                        magnumSummaCumLaude++;
                    else if (promedio == 10)
                        summaCumLaude++;
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
