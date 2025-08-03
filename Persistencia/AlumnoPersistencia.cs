using Datos;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Persistencia
{
    public class AlumnoPersistencia
    {
        public Alumno alumnoEncontradoDni = new Alumno();
        public Alumno alumnoEncontradoId = new Alumno();
        public Alumno BuscarAlumnoPorDni(string dni)
        {
            HttpResponseMessage response = WebHelper.Get("tpIntensivo/alumnos");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                var alumnos = JsonSerializer.Deserialize<List<Alumno>>(contentStream);

                alumnoEncontradoDni = alumnos.Find(a => a.dni.Trim() == dni.Trim());
                return alumnoEncontradoDni;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener alumnos");
            }
        }
        public Alumno BuscarAlumnoPorId(int id)
        {
            HttpResponseMessage response = WebHelper.Get("tpIntensivo/alumnos");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                var alumnos = JsonSerializer.Deserialize<List<Alumno>>(contentStream);

                alumnoEncontradoId = alumnos.Find(a => a.id == id);
                return alumnoEncontradoId;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener alumnos");
            }

        }
        public List<Alumno> buscarAlumnos()
        {
            HttpResponseMessage response = WebHelper.Get("tpIntensivo/alumnos");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var alumnos = JsonSerializer.Deserialize<List<Alumno>>(json);
                return alumnos;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener los alumnos");
            }
        }
        public List<InscripcionMateriaResponse> ObtenerMateriasAprobadas(int alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json);
                var materiasAprobadas = materias.Where(m => m.condicion == "APROBADO").ToList();
                return materiasAprobadas;

            }
            else
            {
                throw new Exception("Error al obtener materias del alumno");
            }
        }
        public List<InscripcionMateriaResponse> ObtenerMateriasNoAprobadas(int alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json);
                var materiasAprobadas = materias.Where(m => m.condicion != "APROBADO").ToList();
                return materiasAprobadas;

            }
            else
            {
                throw new Exception("Error al obtener materias del alumno");
            }
        }

        public List<InscripcionMateriaResponse> ObtenerMateriasFinal(int alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json);
                var materiasAprobadas = materias.Where(m => m.condicion == "FINAL" || m.condicion == "FINAL").ToList();
                return materiasAprobadas;

            }
            else
            {
                throw new Exception("Error al obtener materias del alumno");
            }
        }

        public List<InscripcionMateriaResponse> ObtenerMateriasAprobadasOFinal(int alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json);
                var materiasAprobadas = materias.Where(m => m.condicion == "APROBADO" || m.condicion == "FINAL").ToList();
                return materiasAprobadas;

            }
            else
            {
                throw new Exception("Error al obtener materias del alumno");
            }
        }


        public List<InscripcionMateriaResponse> ObtenerMateriasDelAlumno(int alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return materias ?? new List<InscripcionMateriaResponse>();
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener materias del alumno");
            }
        }
        public bool CrearAlumno(Alumno alumno)
        {
            var json = JsonSerializer.Serialize(alumno);
            HttpResponseMessage response = WebHelper.Post("tpIntensivo/alumnos", json);
            return response.IsSuccessStatusCode;
        }
        public bool EditarAlumno(Alumno alumno)
        {
            var json = JsonSerializer.Serialize(alumno);
            HttpResponseMessage response = WebHelper.Put($"tpIntensivo/alumnos/{alumno.id}", json);
            return response.IsSuccessStatusCode;
        }
        public bool EliminarAlumno(int id)
        {
            HttpResponseMessage response = WebHelper.Delete($"tpIntensivo/alumno/{id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}


