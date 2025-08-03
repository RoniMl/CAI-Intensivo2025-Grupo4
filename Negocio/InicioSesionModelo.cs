using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InicioSesionModelo
    {
        public string? mensajeError;

        public LoginResponse Login(string username, string password)
        {
            LoginPersistencia loginPersistencia = new LoginPersistencia();
            LoginResponse loginResponse = loginPersistencia.login(username, password);
            mensajeError = loginPersistencia.errorMensaje;
            return loginResponse;
        }

    }
}
