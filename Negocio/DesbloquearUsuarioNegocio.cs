using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class DesbloquearUsuarioNegocio
    {
       public DesbloquearUsuarioRequest DesbloquearUsuario(int idUsuario)
        {
            DesbloquearUsuarioRequest desbloquearUsuarioRequest = new DesbloquearUsuarioRequest();
            desbloquearUsuarioRequest.idUsuario = idUsuario;
            DesbloquearUsuarioPersistencia desbloquearUsuarioPersistencia = new DesbloquearUsuarioPersistencia();
            desbloquearUsuarioPersistencia.desbloquearUsuario(desbloquearUsuarioRequest);
            return desbloquearUsuarioRequest;
        }
    }
}
