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
                MateriaReporte materiaReporte = materiaReportes(carrera);
                reportes.Add(materiaReporte);
            }
            return reportes;

        }





        public MateriaReporte materiaReportes(CarreraResponse carrera)
        {
            MateriaReporte materiaReporte = new MateriaReporte();
            List<Alumno> alumnos = alumnoPersistencia.buscarAlumnos();

            string nombreMateria = carrera.nombre;
            int cumLaude = 0;
            int summaCumLaude = 0;
            int magnumSummaCumLaude = 0;
            int totalEgresados = 0;


            foreach (var alumno in alumnos)
            {
                // Obtener alumnos que no le queden materias no aprobadas
                List<InscripcionMateriaResponse> materiasNoAprobadas = alumnoPersistencia.ObtenerMateriasNoAprobadas(alumno.id);
                List<InscripcionMateriaResponse> materiasAprobadas = alumnoPersistencia.ObtenerMateriasAprobadas(alumno.id);
                decimal promedio = 0;
                int notasSumadas = 0;
                if (materiasNoAprobadas.Count == 0)
                {
                    totalEgresados++;                    
                }
                //foreach (int nota in materiasAprobadas.nota)
                //{
                //    notasSumadas += nota;
                //}



            }




            return materiaReporte;
        }



    }
}
