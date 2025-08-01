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

        public List<MateriaReporte> carrerasReporte()
        {
            List<MateriaReporte> reportes = new List<MateriaReporte>();
            List<CarreraResponse> carreras = carreraPersistencia.buscarCarrera();

            foreach (var carrera in carreras)
            {
                MateriaReporte materiaReporte = new MateriaReporte();
                materiaReporte = materiaReportes(carrera);
               reportes.Add(materiaReporte);
            }

           return reportes;
        }

        public MateriaReporte materiaReportes(CarreraResponse carrera)
        {
            List<Alumno> alumnos = alumnoPersistencia.buscarAlumnos();
            MateriaReporte materiaReporte = new MateriaReporte();

            string nombreCarrera = carrera.nombre;
            int cumLaude = 0;
            int summaCumLaude = 0;
            int magnumSummaCumLaude = 0;
            int totalEgresados = 0;

            foreach (var alumno in alumnos)
            {
                foreach (int carreraAlumno in alumno.carrerasId)
                {
                    if (carreraAlumno != carrera.id)
                        continue; // Solo consideramos alumnos de la carrera actual
                }

                var materiasNoAprobadas = alumnoPersistencia.ObtenerMateriasNoAprobadas(alumno.id);
                if (materiasNoAprobadas.Count > 0)
                    continue;

                // Ahora sí es egresado
                totalEgresados++;

                var materiasAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumno.id);
                if (materiasAprobadas.Count == 0)
                    continue; // Por seguridad

                int sumaNotas = materiasAprobadas.Sum(m => m.nota ?? 0);
                decimal promedio = (decimal)sumaNotas / materiasAprobadas.Count;

                // Clasificación por promedio
                if (promedio >= 8 && promedio < 9)
                { 
                    cumLaude++;
                }
                   
                else if (promedio >= 9 && promedio < 10)
                {

                    summaCumLaude++;
                }
                else if (promedio == 10)
                {

                    magnumSummaCumLaude++;
                }
            
            }


            return materiaReporte;
        }

        public List<MateriaReporte> generarReportes()
        {
            List<MateriaReporte> reportes = new List<MateriaReporte>();
            List<CarreraResponse> carreras = new List<CarreraResponse>();
            carreras = carreraPersistencia.buscarCarrera();


            foreach (var carrera in carreras)
            {
                MateriaReporte materiaReporte = new MateriaReporte();
               List<Alumno> alumnos = new List<Alumno>();
                alumnos = alumnoPersistencia.buscarAlumnos();
                List<Alumno>alumnosDeLaCarrera = new List<Alumno>();
                foreach (var alumno in alumnos)
                {
                    foreach(var id in alumno.carrerasId)
                    {
                        alumnosDeLaCarrera.Add(alumno);
                    }
                }
                
                MateriaReporte reporteCarrera = new MateriaReporte();
                string nombreCarrera = carrera.nombre;
                int cumLaude = 0;
                int summaCumLaude = 0;
                int magnumSummaCumLaude = 0;
                int totalEgresados = 0;

                foreach(var a in alumnosDeLaCarrera)
                {
                    List<InscripcionMateriaResponse> matsNoAprobadas = new List<InscripcionMateriaResponse>();
                    matsNoAprobadas = alumnoPersistencia.ObtenerMateriasNoAprobadas(a.id);
                    List<InscripcionMateriaResponse> matsAprobadas = new List<InscripcionMateriaResponse>();
                    matsAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(a.id);
                    int? totalMaterias = matsAprobadas.Count + matsNoAprobadas.Count;
                    int? totalNotas = 0;

                    totalEgresados++;
                    foreach (var m in matsAprobadas)
                    {
                      if (matsNoAprobadas.Count == 0)
                      { 
                            totalNotas += m.nota;
                      }
                    }
                    
                    int? promedio = totalNotas / totalMaterias;
                    if (promedio >= 8 && promedio < 9)
                    {
                        cumLaude++;
                    }

                    else if (promedio >= 9 && promedio < 10)
                    {

                        summaCumLaude++;
                    }
                    else if (promedio == 10)
                    {

                        magnumSummaCumLaude++;
                    }

                    
                } 

                    materiaReporte.totalEgresados = totalEgresados;
                    materiaReporte.cumLaude = cumLaude;
                    materiaReporte.summaCumLaude = summaCumLaude;
                    materiaReporte.magnumSummaCumLaude += magnumSummaCumLaude;

                
                reportes.Add(materiaReporte);
            }


         return reportes;
        }


    }
}
