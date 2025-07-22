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
    class CarreraPersistencia
    {

        public List<CarreraResponse> buscarDatosUsuario()
        {
            List<CarreraResponse> carreras = new List<CarreraResponse>();

            HttpResponseMessage response = WebHelper.Get("tpIntensivo/carreras");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<CarreraResponse> listadoClientes = JsonSerializer.Deserialize<List<CarreraResponse>>(contentStream);
                return listadoClientes;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar los usuarios");
            }

            return carreras;
        }

    }
}