using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Datos;

namespace Persistencia
{
    public class MateriaPersistencia
    {
        public List<Materia> buscarMateriasPorCarrera(long carreraId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/materias/{carreraId}");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<Materia>>(json);
                return materias;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener las materias de la carrera");
            }
        }
    }
}
