using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestionarPersonalNegocio
    {
        public DocentePersistencia docentePersistencia = new DocentePersistencia();
        public CarreraPersistencia carreraPersistencia = new CarreraPersistencia();
        public MateriaPersistencia materiaPersistencia = new MateriaPersistencia(); 
        public CursoPersistencia cursoPersistencia = new CursoPersistencia();

        public Docente BuscarDocentePorDni(string dni)
        {
            return docentePersistencia.BuscarDocentePorDni(dni);
        }

        public bool CrearDocente(Docente docente)
        {
            return docentePersistencia.CrearDocente(docente);
        }
        public bool EliminarDocentePorId(int id)
        {
            return docentePersistencia.EliminarDocente(id);
        }

        public bool EditarDocente(Docente docente)
        {
            return docentePersistencia.EditarDocente(docente);
        }

        public List<Materia> Materias()
        {
            List<Materia> materiasEncontradas = new List<Materia>();
            List<CarreraResponse> carreras = carreraPersistencia.buscarCarrera();
            foreach (var carrera in carreras)
            {
                var materias = materiaPersistencia.buscarMateriasPorCarrera(carrera.id);
                if (materias == null) continue;
                foreach (var materia in materias)
                {
                  //Chequear si no esta la materia en la lista de materiasEncontradas
                    if (!materiasEncontradas.Any(m => m.id == materia.id))
                    {                                             
                          materiasEncontradas.Add(materia);                        
                    }
                }
            }
            return materiasEncontradas;
        }

        public List<CursoResumenDTO> buscarCursos(int idMateria)
        {
            List<CursoResumenDTO> cursosEncontrados = new List<CursoResumenDTO>();
            var cursos = cursoPersistencia.buscarCursosPorMateria(idMateria);
            foreach (var curso in cursos)
            {
                cursosEncontrados.Add(curso);
            }
            return cursosEncontrados;
        }


        public List<CursoAsignado> CursosAsignados(int idDocente)
        {
            List<CursoAsignado> cursosAsignados = new List<CursoAsignado>();

            var carreras = carreraPersistencia.buscarCarrera();

            foreach (var carrera in carreras)
            {
                var materias = materiaPersistencia.buscarMateriasPorCarrera(carrera.id);
                if (materias == null) continue;

                foreach (var materia in materias)
                {
                    var cursos = cursoPersistencia.buscarCursosPorMateria(materia.id);
                    if (cursos == null) continue;

                    foreach (var curso in cursos)
                    {
                        bool yaAgregado = cursosAsignados.Any(ca => ca.Curso.id == curso.id);

                        if (curso.idDocentes != null && curso.idDocentes.Contains(idDocente) && !yaAgregado)
                        {
                            cursosAsignados.Add(new CursoAsignado
                            {
                                NombreMateria = materia.nombre,
                                Curso = curso
                            });
                        }
                    }
                }
            }

            return cursosAsignados;
        }

        








    }
}
