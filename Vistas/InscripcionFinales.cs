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

        public InscripcionFinales(Alumno alumnoLogueado)
        {
            InitializeComponent();
            this.alumno = alumnoLogueado;
        }

        private void InscripcionFinales_Load(object sender, EventArgs e)
        {
            try
            {
                var materiasFinales = _modelo.ObtenerMateriasParaFinal(alumno.id);

                if (materiasFinales == null || materiasFinales.Count == 0)
                {
                    MessageBox.Show("No hay materias disponibles para rendir final.");
                    this.Close();
                    return;
                }

                MateriaFinalCmb.DataSource = materiasFinales;
                MateriaFinalCmb.DisplayMember = "nombre";
                MateriaFinalCmb.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message);
            }
        }

        private void EnviarInscFinBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MateriaFinalCmb.SelectedValue == null)
            //    {
            //        MessageBox.Show("Debe seleccionar una materia.");
            //        return;
            //    }

            //    int idMateria = MateriaFinalCmb.SelectedValue;
            //    _modelo.InscribirAFinal(alumno.id, idMateria);
            //    MessageBox.Show("Inscripción al final realizada con éxito.");
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al inscribirse al final: " + ex.Message);
            //}
        }

        //private void AtrasBtn_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    MenuAlumno menuAlumno = new MenuAlumno(_alumnoId,);
        //    menuAlumno.Show();
        //}

    }
}
