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
    public class CursoPersistencia
    {
        public List<CursoResumenDTO> buscarCursosPorMateria(int materiaId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/cursos/{materiaId}");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var cursos = JsonSerializer.Deserialize<List<CursoResumenDTO>>(json);
                return cursos;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al obtener los cursos de la materia");
            }
        }     
    }
}

