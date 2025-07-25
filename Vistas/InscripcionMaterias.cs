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
    public partial class InscripcionMaterias : Form
    {
        private long _alumnoId;
        private long _carreraId;
        private InscripcionMateriasModelo _modelo;
        private List<Materia> _materiasDisponibles;
        public InscripcionMaterias(long alumnoId, long carreraId)
        {
            InitializeComponent();
            _alumnoId = alumnoId;
            _carreraId = carreraId;
            _modelo = new InscripcionMateriasModelo();

            this.Load += InscripcionMaterias_Load;
        }
        private void InscripcionMaterias_Load(object sender, EventArgs e)
        {
            try
            {
                _materiasDisponibles = _modelo.ObtenerMateriasHabilitadas(_alumnoId, _carreraId);
                CargarMateriasEnComboBox(Materia1Cmb);
                CargarMateriasEnComboBox(Materia2Cmb);
                CargarMateriasEnComboBox(Materia3Cmb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message);
            }
        }
        private void CargarMateriasEnComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = _materiasDisponibles.ToList(); // importante: hacé ToList() para evitar referencia duplicada
            comboBox.DisplayMember = "nombre"; // << asegurate que sea en minúscula
            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = -1;
        }

        private void EnviarInscMatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var idsSeleccionados = new List<long>();

                if (Materia1Cmb.SelectedValue != null) idsSeleccionados.Add(Convert.ToInt64(Materia1Cmb.SelectedValue));
                if (Materia2Cmb.SelectedValue != null) idsSeleccionados.Add(Convert.ToInt64(Materia2Cmb.SelectedValue));
                if (Materia3Cmb.SelectedValue != null) idsSeleccionados.Add(Convert.ToInt64(Materia3Cmb.SelectedValue));

                // Validar que haya al menos una materia
                if (idsSeleccionados.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una materia.");
                    return;
                }

                // Validar que no haya duplicados
                if (idsSeleccionados.Count != idsSeleccionados.Distinct().Count())
                {
                    MessageBox.Show("No se puede seleccionar la misma materia más de una vez.");
                    return;
                }

                _modelo.InscribirAlumnoAMaterias(_alumnoId, idsSeleccionados);
                MessageBox.Show("Inscripción realizada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribirse: " + ex.Message);
            }
        }
        private void AtrasInscMatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

