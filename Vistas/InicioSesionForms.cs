using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Intensivo2025_Grupo4.Modelos; // Asegúrate de que el modelo esté en este espacio de nombres
using CAI_Intensivo2025_Grupo4.Clases; // Asegúrate de que la clase Usuario esté en este espacio de nombres

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class InicioSesionForms : System.Windows.Forms.Form
    {
        private InicioSesionModelo modelo;
        string usuarioIngresado;

        public InicioSesionForms()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            modelo = new InicioSesionModelo();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
                
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text) || string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            } 

            string contraseñaIngresada = ContraseñaTextBox.Text;
            usuarioIngresado = UsuarioTextBox.Text;
            Usuario usuarioEncontrado = modelo.ObtenerUsuario(usuarioIngresado);

            if (usuarioEncontrado == null)
            {
                MessageBox.Show("El usuario y/o la contraseña no son correctos.", "Error");
                return;
            }
            if (usuarioEncontrado.bloqueado)
            {
                MessageBox.Show("El usuario está bloqueado. Por favor, contacte al administrador.", "Error");
                return;
            }
            if ((usuarioEncontrado != null) && (contraseñaIngresada != usuarioEncontrado.contraseña))
            {
                usuarioEncontrado.intentosFallidos++;
                if (usuarioEncontrado.intentosFallidos >= 3)
                {
                    usuarioEncontrado.bloqueado = true;
                    MessageBox.Show("El usuario ha sido bloqueado por demasiados intentos fallidos.", "Error");
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña no son correctos. Intentos fallidos: " + usuarioEncontrado.intentosFallidos, "Error");
                }
                return;
            }
            if (usuarioEncontrado != null && contraseñaIngresada == usuarioEncontrado.contraseña)
            {
                usuarioEncontrado.intentosFallidos = 0; // Reiniciar intentos fallidos al iniciar sesión correctamente
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito");
                // Aquí puedes redirigir al usuario a la siguiente pantalla o realizar otras acciones necesarias
                
            }
           

        }
    }
}
