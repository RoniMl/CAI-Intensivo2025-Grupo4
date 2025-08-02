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

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class MenuAlumno : Form
    {
        private int _alumnoId;
        private int _carreraId;

        public MenuAlumno(int alumnoId, int carreraId)
        {
            InitializeComponent();
            _alumnoId = alumnoId;
            _carreraId = carreraId;
        }

        private void MenuAlumno_Load(object sender, EventArgs e)
        {

        }
        private void btnInscripcionMaterias_Click(object sender, EventArgs e)
        {
            InscripcionMaterias formMaterias = new InscripcionMaterias(_alumnoId, _carreraId);
            formMaterias.Show();
        }

        private void btnInscripcionFinales_Click(object sender, EventArgs e)
        {
            InscripcionFinales formFinales = new InscripcionFinales(_alumnoId);
            formFinales.Show();
        }

        
        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesionForms inicioSesionForms = new InicioSesionForms();
            inicioSesionForms.ShowDialog();
        }
    }
    
}
