using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;
using Datos;
namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }


        private void CerrarSesionBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
            InicioSesionForms inicioSesionForms = new InicioSesionForms();
            inicioSesionForms.ShowDialog();
        }


        public void GenerarReportesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerarReportes generarReporte = new GenerarReportes();
            generarReporte.ShowDialog();
        }

        private void GestionDeDesbloqueosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDesbloqueo gestionDesbloqueo = new GestionDesbloqueo();
            gestionDesbloqueo.ShowDialog();
        }

        private void GestionarPersonalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionPersonal gestionPersonal = new GestionPersonal();
            gestionPersonal.ShowDialog();
        }

        private void GestionarAlumnosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionAlumnos gestionAlumnos = new GestionAlumnos();
            gestionAlumnos.ShowDialog();
        }
    }
}
