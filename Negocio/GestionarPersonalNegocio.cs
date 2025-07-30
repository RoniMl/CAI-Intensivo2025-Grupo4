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

        public Docente ObtenerDocentePorDni(string dni)
        {
            return docentePersistencia.BuscarDocentePorDni(dni);
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






















    }
}
