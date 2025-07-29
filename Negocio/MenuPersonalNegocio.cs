using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MenuPersonalNegocio
    {
        private DocentePersistencia docentePersistencia = new DocentePersistencia();
        public string? mensajeError;
        public Docente docenteEncontrado = new Docente();

        public Docente ObtenerDocentePorId(int id)
        {
            return docentePersistencia.BuscarDocentePorId(id);
        }

        public Docente ValidarDocentePuedeLiquidar(int idDocente)
        {
            try
            {
                Docente docenteTipo = docentePersistencia.BuscarDocentePorId(idDocente);
                docenteEncontrado = docenteTipo;    

                if (docenteTipo == null)
                {
                    mensajeError = "No se encontró al docente.";

                }

                if (docenteTipo.tipo == "AYUDANTE_AD_HONOREM")
                {
                    mensajeError = "El docente es Ad Honorem, por lo tanto no corresponde liquidación.";

                }

                //mensajeError = string.Empty;
                return docenteEncontrado;
            }
            catch (Exception ex)
            {
                mensajeError = $"Error al validar el docente: {ex.Message}";

            }
            return null;
        }


    }
}
