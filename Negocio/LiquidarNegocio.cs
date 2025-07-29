using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class LiquidarNegocio
    {
        public Docente? docenteEnLiquidacion;
        public DocentePersistencia docentePersistencia = new DocentePersistencia();
        public CarreraPersistencia carreraPersistencia = new CarreraPersistencia();
        public CursoPersistencia cursoPersistencia = new CursoPersistencia();
        public MateriaPersistencia materiaPersistencia = new MateriaPersistencia();

        //public string mensaje = string.Empty;   PARA VER DESPUES DE PASAR UN ERROR SI ES AD HONOREM

        // Precio y coeficientes para la liquidación
        private const decimal PrecioHora = 7700m;
        private const decimal CoefProfesor = 1.2m;
        private const decimal CoefAyudante = 1.05m;
        private const decimal CoefAntiguedadPor5Anos = 1.1m;

        // Método principal para calcular horas y sueldo
        public DocenteLiquidacion LiquidarDocente(Docente docente)
        {
            int horasTotales = 0;
            decimal sueldo = 0;
            string mensajeError = "";
            
            DocenteLiquidacion DocenteLiquidacion = new DocenteLiquidacion
            {
                nombre = docente.nombre,
                apellido = docente.apellido,
                cuit = docente.cuit,
                horasTotales = horasTotales, 
                sueldo = sueldo,
                mensajeError = mensajeError
            };
            

            try
            {
                List<CarreraResponse> carreras = carreraPersistencia.buscarCarrera();
                if (carreras == null) throw new Exception("No se pudieron obtener las carreras.");

                foreach (var carrera in carreras)
                {
                    var materias = materiaPersistencia.buscarMateriasPorCarrera(carrera.Id);
                    if (materias == null) continue;

                    foreach (var materia in materias)
                    {
                        var cursos = cursoPersistencia.buscarCursosPorMateria(materia.id);
                        if (cursos == null) continue;

                        foreach (var curso in cursos)
                        {
                            if (curso.idDocentes != null && curso.idDocentes.Contains(docente.id))
                            {
                                horasTotales += materia.horasSemanales;
                            }
                        }
                    }
                }

                // Cálculo de sueldo
                decimal coefCargo = docente.tipo == "PROFESOR" ? CoefProfesor : CoefAyudante;
                int bloquesDeCincoAnios = docente.antiguedad / 5; // Se aplica por bloques de 5 años completos
                decimal coefAntiguedad = (decimal)Math.Pow((double)CoefAntiguedadPor5Anos, bloquesDeCincoAnios);
                sueldo = horasTotales * PrecioHora * coefCargo * coefAntiguedad;

            }
            catch (Exception ex)
            {
                mensajeError = "Error al calcular liquidación: " + ex.Message;
            }

            return DocenteLiquidacion;
        }

        //public Docente ValidarDocentePuedeLiquidar(int idDocente, out string mensaje)
        //{
        //    try
        //    {
        //        Docente docenteTipo = docentePersistencia.BuscarDocentePorId(idDocente);

        //        if (docenteTipo == null)
        //        {
        //            mensaje = "No se encontró al docente.";
                    
        //        }

        //        if (docenteTipo.tipo == "AYUDANTE_AD_HONOREM")
        //        {
        //            mensaje = "El docente es Ad Honorem, por lo tanto no corresponde liquidación.";
                    
        //        }

        //        mensaje = string.Empty;
        //        return docenteTipo;
        //    }
        //    catch (Exception ex)
        //    {
        //        mensaje = $"Error al validar el docente: {ex.Message}";
                
        //    }
        //    return null;
        //}






        //public int CalcularHorasTotalesDocente(int idProfesor)
        //{
        //    int horasTotales = 0;
        //    List<int> idCarreras = carreraPersistencia.buscarCarrera().id;
        //    return idCarreras;
        //}

        //foreach(int i in idCarreras){ 

        //public List<int> ObtenerMaterias(int idCarreras)
        //{
        //    List<int> idMaterias = materiaPersistencia.buscarMateriasPorCarrera(idCarreras);
        //    return idMaterias;
        //}

        //public List<CursoResumenDTO> ObtenerCursos(int idMaterias)
        //{
        //    List<CursoResumenDTO> cursos = cursoPersistencia.buscarCursosPorMateria(idMaterias);
        //    return cursos;

        //}

        //foreach(CursoResumenDTO curso in cursos){
        //    if(Curso.idDocente.contains(idProfesor)){

        //    horasTotales += curso.horasSemanales
        //       }
        //   }
        //}
    }
}



      
