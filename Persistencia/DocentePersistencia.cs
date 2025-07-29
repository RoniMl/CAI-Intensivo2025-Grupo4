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
        public Docente docenteEncontradoDni = new Docente();
        public Docente docenteEncontradoId = new Docente();
        //public List<Docente> buscarDocentes()
        //{
        //    List<Docente> docentes = new List<Docente>();

        //    HttpResponseMessage response = WebHelper.Get("tpIntensivo/docentes");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var contentStream = response.Content.ReadAsStringAsync().Result;
        //        List<Docente> listadoDocentes = JsonSerializer.Deserialize<List<Docente>>(contentStream);
        //        return listadoDocentes;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
        //        throw new Exception("Error al obtener docentes");
        //    }
        //}

        public Docente BuscarDocentePorDni(string dni)
        {
            HttpResponseMessage response = WebHelper.Get("tpIntensivo/docentes");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                var docentes = JsonSerializer.Deserialize<List<Docente>>(contentStream);

                docenteEncontradoDni = docentes.Find(d => d.dni.Trim() == dni.Trim());
                // Busca el docente que tenga el mismo DNI (sin espacios, por las dudas)
                return docenteEncontradoDni;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener docentes");
            }
        }

        public Docente BuscarDocentePorId(int id)
        {
            HttpResponseMessage response = WebHelper.Get("tpIntensivo/docentes");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                var docentes = JsonSerializer.Deserialize<List<Docente>>(contentStream);

                docenteEncontradoId = docentes.Find(d => d.id == id);
                // Busca el docente que tenga el mismo DNI (sin espacios, por las dudas)
                return docenteEncontradoId;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener docentes");
            }
        }

        public bool EliminarDocente(int id)
        {
            HttpResponseMessage response = WebHelper.Delete($"tpIntensivo/docentes/{id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditarDocente(Docente docente)
        {
            var json = JsonSerializer.Serialize(docente);
            HttpResponseMessage response = WebHelper.Put($"tpIntensivo/docentes/{docente.id}", json);

            return response.IsSuccessStatusCode;
        }


    }
}
