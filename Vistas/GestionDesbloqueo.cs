using CAI_Intensivo2025_Grupo4.Vistas;
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

namespace Vistas
{
    public partial class GestionDesbloqueo : Form
    {
        public int idUsuarioSeleccionado;

        public GestionDesbloqueo()
        {
            InitializeComponent();
        }

        private void DesbloquearBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DesbloquearTextBox.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del usuario a desbloquear.", "Error");
                return;
            }

            if (int.TryParse(DesbloquearTextBox.Text, out idUsuarioSeleccionado))
            {
                DesbloquearUsuarioNegocio desbloquearUsuarioNegocio = new DesbloquearUsuarioNegocio();
                bool resultadoForm = desbloquearUsuarioNegocio.DesbloquearUsuario(idUsuarioSeleccionado);
                if (resultadoForm)
                {
                    MessageBox.Show("El usuario ha sido desbloqueado exitosamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo desbloquear el usuario. Verifique el ID e inténtelo de nuevo.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido.", "Error");
            }

        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdmin = new MenuAdministrador();
            menuAdmin.Show();

            this.Close();
        }
    }
}
