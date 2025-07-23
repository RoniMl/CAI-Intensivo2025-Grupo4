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
        public int maxIntentosFallidos = 3;
        public int contadorIntentosFallidos = 0;
        public string? mensajeError;

        public LoginResponse Login(string username, string password)
        {
            LoginPersistencia loginPersistencia = new LoginPersistencia();
            LoginResponse loginResponse = loginPersistencia.login(username, password);
            //manejarErrores(loginPersistencia.error);
            mensajeError = loginPersistencia.errorMensaje;

            return loginResponse;
        }



        //public string manejarErrores(string error)
        //{
           
        //    if (error == "401")
        //    {
               
        //        if (contadorIntentosFallidos >= maxIntentosFallidos)
        //        {
        //            mensajeError = "Has superado el número máximo de intentos fallidos. Tu cuenta ha sido bloqueada por seguridad.";
        //        }
        //        else
        //        {
        //            mensajeError = "Usuario y/o contraseña incorrectos. Por favor, inténtalo de nuevo.";
                    
        //        }
        //    } else
        //    {
        //        mensajeError = "Error desconocido. Por favor, inténtalo de nuevo más tarde.";
        //    }

        //    return mensajeError;
        //}
        

       

        //Base de datos simulada para usuarios
        //private List<Usuario> usuarios = new List<Usuario>
        //{
        //    new Usuario { usuario = "admin", contraseña = "admin123", intentosFallidos = 0, bloqueado = false},
        //    new Usuario { usuario = "user1", contraseña = "password1", intentosFallidos = 0, bloqueado = false}
        //};

        //public bool verificarUsuario(string usuarioIngresado)
        //{
        //    // Aquí deberías implementar la lógica para verificar si el usuario existe en tu base de datos o lista de usuarios.
        //    // Por ahora, retornaremos true como un ejemplo.
        //    return true;
        //}

        //public bool verificarContraseña(string usuarioIngresado, string contraseña)
        //{
        //    // Aquí deberías implementar la lógica para verificar si la contraseña es correcta.
        //    // Por ahora, retornaremos true como un ejemplo.
        //    return true;
        //}



    }
}
