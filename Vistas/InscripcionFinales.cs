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
    public partial class InscripcionFinales : Form
    {
        private InscripcionFinalesModelo _modelo = new InscripcionFinalesModelo();
        public Alumno alumno;
        List<InscripcionMateriaResponse> materiasFinales = new List<InscripcionMateriaResponse>();
        public InscripcionFinales(Alumno alumnoLogueado)
        {
            InitializeComponent();
            this.alumno = alumnoLogueado;
        }

        private void InscripcionFinales_Load(object sender, EventArgs e)
        {
            try
            {
                materiasFinales = _modelo.ObtenerMateriasParaFinal(alumno.id);

                if (materiasFinales == null || materiasFinales.Count == 0)
                {
                    MessageBox.Show("No hay materias disponibles para rendir final.");

                    MateriaFinalCmb.Enabled = false;
                    EnviarInscFinBtn.Enabled = false;

                    return;
                }

                foreach (var materia in materiasFinales)
                {
                    MateriaFinalCmb.Items.Add(materia.nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message);
            }
        }

        private void EnviarInscFinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MateriaFinalCmb.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una materia.");
                    return;
                }

                int idMateria = materiasFinales[MateriaFinalCmb.SelectedIndex].id;

                string mensaje = "Materias seleccionada (ID): " + string.Join(", ", idMateria);
                MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _modelo.InscribirAFinal(alumno.id, idMateria);

                MessageBox.Show("Inscripción al final realizada con éxito.");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribirse al final: " + ex.Message);
            }
        }

        private void AtrasInscFinBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlumno menuAlumno = new MenuAlumno(alumno.id);
            menuAlumno.Show();
        }
    }
}
