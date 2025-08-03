using Datos;
using System.Text.Json;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class CarreraPersistencia
    {
        public List<CarreraResponse> buscarCarrera()
        {
            List<CarreraResponse> carreras = new List<CarreraResponse>();

            HttpResponseMessage response = WebHelper.Get("tpIntensivo/carreras");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<CarreraResponse> listadoCarrera = JsonSerializer.Deserialize<List<CarreraResponse>>(contentStream);              
                return listadoCarrera;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar las carreras");
            }

        }
        public CarreraResponse ObtenerCarreraPorId(int id)
        {
            var carreras = buscarCarrera(); // trae todas las carreras desde la API
            return carreras.FirstOrDefault(c => c.id == id);
        }

    }
}