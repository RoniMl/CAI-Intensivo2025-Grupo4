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
       
        public bool DesbloquearUsuario(int idUsuario)
        {
            DesbloquearUsuarioPersistencia desbloquearUsuarioPersistencia = new DesbloquearUsuarioPersistencia();
            bool resultado = desbloquearUsuarioPersistencia.desbloquearUsuario(idUsuario);
            
            return resultado;
        }
    }
}
