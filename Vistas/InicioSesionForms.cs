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
    public partial class InicioSesionForms : System.Windows.Forms.Form
    {
        public InicioSesionForms()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar cualquier lógica que necesites al cargar el formulario
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text) || string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }
        }
    }
}
