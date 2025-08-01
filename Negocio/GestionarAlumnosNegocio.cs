using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class GestionarAlumnosNegocio
    {
        private AlumnoPersistencia alumnoPersistencia = new AlumnoPersistencia();
        private CarreraPersistencia carreraPersistencia = new CarreraPersistencia();

        public Alumno BuscarAlumnoPorDni(string dni)
        {
            return alumnoPersistencia.BuscarAlumnoPorDni(dni);
        }

        public Alumno BuscarAlumnoPorId(int id)
        {
            return alumnoPersistencia.BuscarAlumnoPorId(id);
        }

        //esta de mas?
        //public List<Alumno> BuscarAlumnos()
        //{
        //    return alumnoPersistencia.buscarAlumnos();
        //}

        public bool CrearAlumno(Alumno alumno)
        {
            return alumnoPersistencia.CrearAlumno(alumno);
        }

        public bool EditarAlumno(Alumno alumno)
        {
            return alumnoPersistencia.EditarAlumno(alumno);
        }

        public bool EliminarAlumnoPorId(int id)
        {
            return alumnoPersistencia.EliminarAlumno(id);
        }

        public List<CarreraResponse> Carreras()
        {
            return carreraPersistencia.buscarCarrera();
        }

        public List<CarreraResponse> CarrerasAsignadasAlumno(int idAlumno)
        {
            Alumno alumno = alumnoPersistencia.BuscarAlumnoPorId(idAlumno);

            if (alumno == null)
                throw new Exception($"No se encontró el alumno con ID {idAlumno}");

            if (alumno.carrerasIds == null || !alumno.carrerasIds.Any())
                throw new Exception($"El alumno con ID {idAlumno} no tiene carreras asignadas.");

            List<CarreraResponse> todasLasCarreras = carreraPersistencia.buscarCarrera();

            var carrerasAsignadas = todasLasCarreras
                .Where(c => alumno.carrerasIds.Contains(c.id))
                .ToList();

            return carrerasAsignadas;
        }
    }
}
