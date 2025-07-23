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
    public partial class InscripcionMaterias : Form
    {
        public InscripcionMaterias()
        {
            InitializeComponent();
        }

        private long idAlumno;

        public InscripcionMaterias(long idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
        }

    }
}
