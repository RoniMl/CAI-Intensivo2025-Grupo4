using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos; 
using Negocio;
using Persistencia;
using Vistas;
using Windows.Graphics.Printing.OptionDetails; 

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class InicioSesionForms : System.Windows.Forms.Form
    {
        private InicioSesionModelo modelo;
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
            contraseñaIngresada = ContraseñaTextBox.Text.Trim();
            usuarioIngresado = UsuarioTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }

            //VALIDACION DE USUARIO Y CONTRASEÑA DE 8 DIGITOS CON LETRAS Y NUMEROS  (DESCOMENTAR PARA ENTREGAR)

            //if (usuarioIngresado.Length != 8 || !usuarioIngresado.All(char.IsLetterOrDigit))
            //{
            //    MessageBox.Show("El nombre de usuario debe tener exactamente 8 caracteres, compuestos por letras y números.", "Error de validación");
            //    return;
            //}

            //// Validación de contraseña: mínimo 8 caracteres, al menos una letra y un número
            //bool contieneLetra = contraseñaIngresada.Any(char.IsLetter);
            //bool contieneNumero = contraseñaIngresada.Any(char.IsDigit);

            //if (contraseñaIngresada.Length < 8 || !contieneLetra || !contieneNumero)
            //{
            //    MessageBox.Show("La contraseña debe tener al menos 8 caracteres y contener tanto letras como números.", "Error de validación");
            //    return;
            //}

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
