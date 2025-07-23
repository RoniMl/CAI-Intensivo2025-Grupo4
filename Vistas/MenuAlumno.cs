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
        private long _alumnoId;
        private long _carreraId;

        public MenuAlumno(long alumnoId, long carreraId)
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
            InscripcionFinales formFinales = new InscripcionFinales();
            formFinales.Show();
        }
    }
}
