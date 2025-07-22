using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Intensivo2025_Grupo4.Negocio
{
    public class InicioSesionModelo
    {
        //Base de datos simulada para usuarios
        private List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { usuario = "admin", contraseña = "admin123", intentosFallidos = 0, bloqueado = false, credenciales = 0 },
            new Usuario { usuario = "user1", contraseña = "password1", intentosFallidos = 0, bloqueado = false, credenciales = 0 }
        };

        public bool verificarUsuario(string usuarioIngresado)
        {
            // Aquí deberías implementar la lógica para verificar si el usuario existe en tu base de datos o lista de usuarios.
            // Por ahora, retornaremos true como un ejemplo.
            return true;
        }

        public bool verificarContraseña(string usuarioIngresado, string contraseña)
        {
            // Aquí deberías implementar la lógica para verificar si la contraseña es correcta.
            // Por ahora, retornaremos true como un ejemplo.
            return true;
        }

        public Usuario ObtenerUsuario(string usuarioIngresado)
        {
            return usuarios.SingleOrDefault(u => u.usuario == usuarioIngresado);
        }


    }
}
