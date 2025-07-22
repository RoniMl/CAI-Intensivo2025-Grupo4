using Datos;
using System.Text.Json;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Persistencia
{
    public class DocentePersistencia
    {
        public List<Docente> buscarDocentes()
        {
            List<Docente> docentes = new List<Docente>();

            HttpResponseMessage response = WebHelper.Get("tpIntensivo/docentes");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Docente> listadoDocentes = JsonSerializer.Deserialize<List<Docente>>(contentStream);
                return listadoDocentes;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener docentes");
            }
        }
    }
}
