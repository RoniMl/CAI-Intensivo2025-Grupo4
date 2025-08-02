using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos; // Asegúrate de que el modelo esté en este espacio de nombres
using Negocio;
using Persistencia;
using Vistas;
using Windows.Graphics.Printing.OptionDetails; // Asegúrate de que la clase Usuario esté en este espacio de nombres

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class InicioSesionForms : System.Windows.Forms.Form
    {
        private InicioSesionModelo modelo;
        //public int contadorIntentosFallidos = 0;
        public string usuarioIngresado;
        public string contraseñaIngresada;

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
            contraseñaIngresada = ContraseñaTextBox.Text;
            usuarioIngresado = UsuarioTextBox.Text;

            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }

            InicioSesionModelo loginNegocio = new InicioSesionModelo();
            LoginResponse login = loginNegocio.Login(usuarioIngresado, contraseñaIngresada);
            LiquidarNegocio liquidarNegocio = new LiquidarNegocio();


            if (login != null)
            {

                switch (login.perfilUsuario)
                {
                    case "ALUMNO":

                        int idAlumno = login.id;                        

                        this.Hide();
                        MenuAlumno menuAlumno = new MenuAlumno(idAlumno);
                        menuAlumno.ShowDialog();
                        break;

                    case "ADMIN":
                        this.Hide();
                        MenuAdministrador menuAdministrador = new MenuAdministrador();
                        menuAdministrador.ShowDialog();
                        break;

                    case "PERSONAL":

                        int idDocenteLogin = login.id;

                        this.Hide();
                        MenuPersonal menuPersonal = new MenuPersonal(idDocenteLogin);
                        //liquidarNegocio.LiquidarDocente(login.id); // Llamada al método de liquidación de docente
                        menuPersonal.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Perfil de usuario no reconocido.");
                        break;
                }

            }
            else
            {
                MessageBox.Show(loginNegocio.mensajeError, "Error");
            }

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
