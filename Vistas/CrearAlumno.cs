using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class CrearAlumno : Form
    {
        private CrearAlumnoNegocio negocio;
        public CrearAlumno()
        {
            InitializeComponent();
        }

        private void CrearAlumnoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTxb.Text) || string.IsNullOrEmpty(ApellidoTxb.Text) || string.IsNullOrEmpty(DniTxb.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chequear que se haya añadido alguna carrera al alumno
            if (CarreraListView.Items.Count == 0)
            {
                MessageBox.Show("Por favor, añada al menos una carrera al alumno.", "Carreras incompletas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Chequear que el usuario tenga 8 caracteres con al menos una letra y un número
            if (UsuarioTxb.Text.Length < 8 || !UsuarioTxb.Text.Any(char.IsLetter) || !UsuarioTxb.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El usuario debe tener al menos 8 caracteres, incluyendo al menos una letra y un número.", "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Chequear que la contraseña tenga 8 caracteres con al menos una letra y un número
            if (ContraseñaTbx.Text.Length < 8 || !ContraseñaTbx.Text.Any(char.IsLetter) || !ContraseñaTbx.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluyendo al menos una letra y un número.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var alumno = new Alumno
            {
                nombre = NombreTxb.Text,
                apellido = ApellidoTxb.Text,
                dni = DniTxb.Text,
                usuario = new Usuario
                {
                    usuario = UsuarioTxb.Text,
                    contraseña = ContraseñaTbx.Text
                }
            };

            negocio.NuevoAlumno(alumno);

        }

        private void AñadirBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
