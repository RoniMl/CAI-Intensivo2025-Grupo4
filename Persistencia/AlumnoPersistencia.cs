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
    }
}