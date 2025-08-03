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
        private MenuAlumnoNegocio negocio = new MenuAlumnoNegocio();
        public int idAlumno;
        private Alumno alumno;
        public MenuAlumno(int idAlumno)
        {
            InitializeComponent();
            alumno = negocio.ObtenerAlumnoPorId(idAlumno);
            this.idAlumno = idAlumno;
        }

        private void MenuAlumno_Load(object sender, EventArgs e)
        {

        }
        private void btnInscripcionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new InscripcionMaterias(alumno);
            form.Show();
        //    InscripcionMaterias formMaterias = new InscripcionMaterias(alumnoId, carreraId);
        //    formMaterias.Show();
        }

        private void btnInscripcionFinales_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new InscripcionFinales(alumno);
            form.Show();
            //InscripcionFinales formFinales = new InscripcionFinales(_alumnoId);
            //formFinales.Show();
        }

        
        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioSesionForms inicioSesionForms = new InicioSesionForms();
            inicioSesionForms.ShowDialog();
        }
    }
    
}
