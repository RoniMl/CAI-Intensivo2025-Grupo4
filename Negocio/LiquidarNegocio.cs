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
        

        // Precio y coeficientes para la liquidación
        private const decimal PrecioHora = 7700m;
        private const decimal CoefProfesor = 1.2m;
        private const decimal CoefAyudante = 1.05m;
        private const decimal CoefAntiguedadPor5Anos = 1.1m;

        public DocenteLiquidacion LiquidarDocente(Docente docente)
        {
            int horasTotales = 0;
            decimal sueldo = 0;
            string mensajeError = "";
            
            

            try
            {
                List<CarreraResponse> carreras = carreraPersistencia.buscarCarrera();
                if (carreras == null) throw new Exception("No se pudieron obtener las carreras.");

                foreach (var carrera in carreras)
                {
                    var materias = materiaPersistencia.buscarMateriasPorCarrera(carrera.id);
                   // if (materias == null) continue;

                    foreach (var materia in materias)
                    {
                        var cursos = cursoPersistencia.buscarCursosPorMateria(materia.id);
                        if (cursos == null) continue;

                        foreach (var curso in cursos)
                        {
                            if (curso.idDocentes != null && curso.idDocentes.Contains(docente.id))
                            {
                                if (materia.horasSemanales == 2)
                                {
                                    horasTotales += materia.horasSemanales * 4 * curso.horarios.Count(); 
                                } else
                                {
                                    horasTotales += materia.horasSemanales * 4 ;
                                }
                            }
                        }
                    }
                }

                // Cálculo de sueldo
                decimal coefCargo = docente.tipo == "PROFESOR" ? CoefProfesor : CoefAyudante;
                int bloquesDeCincoAnios = docente.antiguedad / 5; 
                decimal coefAntiguedad = (decimal)Math.Pow((double)CoefAntiguedadPor5Anos, bloquesDeCincoAnios);
                sueldo = horasTotales * PrecioHora * coefCargo * coefAntiguedad;

            }
            catch (Exception ex)
            {
                mensajeError = "Error al calcular liquidación: " + ex.Message;
            }

            DocenteLiquidacion DocenteLiquidacion = new DocenteLiquidacion
            {
                nombre = docente.nombre,
                apellido = docente.apellido,
                cuit = docente.cuit,
                horasTotales = horasTotales, 
                sueldo = sueldo,
                mensajeError = mensajeError
            };


            return DocenteLiquidacion;
        }

    }
}



      
