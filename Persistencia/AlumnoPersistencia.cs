using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Datos;
using System.Net.Http;


namespace Persistencia
{
    public class AlumnoPersistencia
    {
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


        public List<InscripcionMateriaResponse> ObtenerMateriasAprobadas(long alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json);
                Console.WriteLine("JSON recibido para materias inscriptas:");//ultimo añadido
                Console.WriteLine(json);

                //ESTE FOREACH PUEDE VOLAR, ULTIMO AGREGADO.
                foreach (var m in materias)
                {
                    Console.WriteLine($"Materia: {m.nombre}, Condición: {m.condicion}");
                }
                return materias.Where(m => m.condicion.ToLower() == "aprobada").ToList();
            }
            else
            {
                throw new Exception("Error al obtener materias del alumno");
            }
        }
    }
}



/* MODELO VIEJO DE BUSCAR ALUMNO
if (response.IsSuccessStatusCode)
{
    string json = response.Content.ReadAsStringAsync().Result;
    return JsonSerializer.Deserialize<Alumno>(json);
}
else
{
    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
    throw new Exception("Error al obtener el alumno por ID");
}





SEGUNDO 
        public Alumno ObtenerAlumnoPorId(long id)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{id}");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var alumno = JsonSerializer.Deserialize<Alumno>(json);
                return alumno;
            }
            else
            {
                throw new Exception("No se pudo obtener el alumno");
            }

        }
*/