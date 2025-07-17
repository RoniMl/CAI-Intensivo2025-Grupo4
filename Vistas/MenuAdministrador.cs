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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void GestionatAlumnosBtn_Click(object sender, EventArgs e)
        {

        }

       private void CerrarSesionBtn_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación al hacer clic en el botón de cerrar sesión
            Application.Exit();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
