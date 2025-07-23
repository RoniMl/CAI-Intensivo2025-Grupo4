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
    public partial class MenuAlumno : Form
    {
        public MenuAlumno()
        {
            InitializeComponent();
        }

        private void MenuAlumno_Load(object sender, EventArgs e)
        {

        }
        private void btnInscripcionMaterias_Click(object sender, EventArgs e)
        {
            InscripcionMaterias formMaterias = new InscripcionMaterias();
            formMaterias.Show();
        }

        private void btnInscripcionFinales_Click(object sender, EventArgs e)
        {
            InscripcionFinales formFinales = new InscripcionFinales();
            formFinales.Show();
        }

        private long idAlumno;

        public MenuAlumno(long idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
        }

        private void ModuloInscMatBtn(object sender, EventArgs e)
        {
            var formMaterias = new InscripcionMaterias(idAlumno);
            formMaterias.ShowDialog();
        }
    }
}
