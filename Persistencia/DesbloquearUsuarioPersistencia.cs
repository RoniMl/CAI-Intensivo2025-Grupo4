using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Text.Json;
using Persistencia.utils;


namespace Persistencia
{
    internal class DesbloquearUsuarioPersistencia
    {
        public DesbloquearUsuarioRequest desbloquearUsuario(int idUsuario)
        {
            DesbloquearUsuarioRequest datos = new DesbloquearUsuarioRequest();
            datos.idUsuario = idUsuario;

            var jsonData = JsonSerializer.Serialize(datos);
            HttpResponseMessage response = WebHelper.Post("tpIntensivo/desbloquear", jsonData);
        }
    }
}
