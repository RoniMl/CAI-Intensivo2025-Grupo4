using Datos;
using Negocio;
using Persistencia;
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
        public Alumno alumno;
        private CarreraPersistencia carreraPersistencia = new CarreraPersistencia();
        private MateriaPersistencia materiaPersistencia = new MateriaPersistencia();
        private InscripcionMateriasModelo modelo = new InscripcionMateriasModelo();
        private List<Materia> materiasHabilitadas = new List<Materia>();
        public InscripcionMaterias(Alumno alumnoLogueado)
        {
            InitializeComponent();
            this.alumno = alumnoLogueado;
            CargarMateriasHabilitadas();           
            
            double ranking = modelo.calcularRanking(alumno.id);
            rankingListView.Items.Clear();
            ListViewItem item = new ListViewItem(ranking.ToString());
            rankingListView.Items.Add(item);
        }

        private void CargarMateriasHabilitadas()
        {
            materiasHabilitadas.Clear();

            var carreras = carreraPersistencia.buscarCarrera();
            var carrerasDelAlumno = carreras.Where(c => alumno.carrerasIds.Contains(c.id)).ToList();

            foreach (var carrera in carrerasDelAlumno)
            {
                var habilitadas = modelo.ObtenerMateriasHabilitadas(alumno.id, carrera.id);

                foreach (var materia in habilitadas)
                {
                    if (!materiasHabilitadas.Any(m => m.id == materia.id))
                        materiasHabilitadas.Add(materia);
                }
            }

            // Cargar nombres al combo
            Materia1Cmb.Items.Clear();
            Materia2Cmb.Items.Clear();
            Materia3Cmb.Items.Clear();

            foreach (var materia in materiasHabilitadas)
            {
                Materia1Cmb.Items.Add(materia.nombre);
                Materia2Cmb.Items.Add(materia.nombre);
                Materia3Cmb.Items.Add(materia.nombre);
            }
        }        

        private void EnviarBtn_Click(object sender, EventArgs e)
        {
            var materiasSeleccionadas = new List<Materia>();

            // Agregar materias seleccionadas sin duplicar código
            ComboBox[] comboBoxes = { Materia1Cmb, Materia2Cmb, Materia3Cmb };

            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem != null)
                {
                    string nombreSeleccionado = comboBox.SelectedItem.ToString();
                    var materia = materiasHabilitadas.FirstOrDefault(m => m.nombre == nombreSeleccionado);

                    if (materia != null)
                        materiasSeleccionadas.Add(materia);
                }
            }

            // Validaciones
            if (materiasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una materia para inscribirse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica duplicados por ID
            var ids = materiasSeleccionadas.Select(m => m.id).ToList();
            bool hayDuplicados = ids.Count != ids.Distinct().Count();

            if (hayDuplicados)
            {
                MessageBox.Show("No puede inscribirse dos veces a la misma materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mensaje de prueba: muestra los IDs
            string mensaje = "Materias seleccionadas (IDs): " + string.Join(", ", ids);
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtrasInscMatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlumno menuAlumno = new MenuAlumno(alumno.id);
            menuAlumno.Show();
        }


        //private int _alumnoId;
        //private int _carreraId;
        //private InscripcionMateriasModelo _modelo;
        //private List<Materia> _materiasDisponibles;
        //public InscripcionMaterias(int alumnoId, int carreraId)
        //{
        //    InitializeComponent();
        //    _alumnoId = alumnoId;
        //    _carreraId = carreraId;
        //    _modelo = new InscripcionMateriasModelo();

        //    this.Load += InscripcionMaterias_Load;
        //}
        //private void InscripcionMaterias_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        _materiasDisponibles = _modelo.ObtenerMateriasHabilitadas(_alumnoId, _carreraId);
        //        CargarMateriasEnComboBox(Materia1Cmb);
        //        CargarMateriasEnComboBox(Materia2Cmb);
        //        CargarMateriasEnComboBox(Materia3Cmb);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar materias: " + ex.Message);
        //    }
        //    // Mostrar ranking en el rankingListView
        //    int ranking = _modelo.calcularRanking(_alumnoId);
        //    rankingListView.Items.Clear();
        //    ListViewItem item = new ListViewItem(ranking.ToString());
        //    rankingListView.Items.Add(item);


        //}
        //private void CargarMateriasEnComboBox(ComboBox comboBox)
        //{
        //    comboBox.DataSource = _materiasDisponibles.ToList(); // importante: hacé ToList() para evitar referencia duplicada
        //    comboBox.DisplayMember = "nombre"; // << asegurate que sea en minúscula
        //    comboBox.ValueMember = "id";
        //    comboBox.SelectedIndex = -1;
        //}



        //private void EnviarInscMatBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var idsSeleccionados = new List<long>();

        //        if (Materia1Cmb.SelectedValue != null) idsSeleccionados.Add(Convert.ToInt64(Materia1Cmb.SelectedValue));
        //        if (Materia2Cmb.SelectedValue != null) idsSeleccionados.Add(Convert.ToInt64(Materia2Cmb.SelectedValue));
        //        if (Materia3Cmb.SelectedValue != null) idsSeleccionados.Add(Convert.ToInt64(Materia3Cmb.SelectedValue));

        //        // Validar que haya al menos una materia
        //        if (idsSeleccionados.Count == 0)
        //        {
        //            MessageBox.Show("Debe seleccionar al menos una materia.");
        //            return;
        //        }

        //        // Validar que no haya duplicados
        //        if (idsSeleccionados.Count != idsSeleccionados.Distinct().Count())
        //        {
        //            MessageBox.Show("No se puede seleccionar la misma materia más de una vez.");
        //            return;
        //        }
        //        foreach (int id in idsSeleccionados)
        //        {
        //            _modelo.InscribirAlumnoAMaterias(_alumnoId, id);
        //        }

        //        MessageBox.Show("Inscripción realizada correctamente.");
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al inscribirse: " + ex.Message);
        //    }
        //}
        //private void AtrasInscMatBtn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}

