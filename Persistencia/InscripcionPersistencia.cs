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
    public class InscripcionPersistencia
    {
        // Obtener materias en las que el alumno está inscripto
        public List<InscripcionMateriaResponse> ObtenerMateriasInscriptas(long alumnoId)
        {
            HttpResponseMessage response = WebHelper.Get($"tpIntensivo/alumno/{alumnoId}/materias");

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var materias = JsonSerializer.Deserialize<List<InscripcionMateriaResponse>>(json);
                return materias;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("No se pudieron obtener las materias inscriptas.");
            }
        }

        // Inscribir al alumno en una lista de materias (array de IDs)
        public void InscribirMaterias(long alumnoId, int idsMaterias)
        {
            string json = JsonSerializer.Serialize(idsMaterias);
            HttpResponseMessage response = WebHelper.Post($"tpIntensivo/alumno/{alumnoId}/materias", json);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("No se pudieron inscribir las materias.");
            }
        }
        public void InscribirAFinal(int alumnoId, int materiaId)
        {
            List<int> materiasIds = new List<int> { materiaId };
            string json = JsonSerializer.Serialize(materiasIds);

            HttpResponseMessage response = WebHelper.Post($"tpIntensivo/alumno/{alumnoId}/materias", json);

            if (!response.IsSuccessStatusCode)
            {

                throw new Exception("No se pudo inscribir al final");
            }
        }

    }
}
