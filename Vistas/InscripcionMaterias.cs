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
    public partial class InscripcionMaterias : Form
    {
        public Alumno alumno;           
        private InscripcionMateriasModelo modelo = new InscripcionMateriasModelo();
        private List<Materia> materiasHabilitadas = new List<Materia>();
        private List<CursoResumenDTO> cursos1 = new();
        private List<CursoResumenDTO> cursos2 = new();
        private List<CursoResumenDTO> cursos3 = new();
        private List<CursoResumenDTO> cursosSeleccionados = new List<CursoResumenDTO>();
        
        public InscripcionMaterias(Alumno alumnoLogueado)
        {
            InitializeComponent();
            this.alumno = alumnoLogueado;
            
            Materia1Cmb.SelectedIndexChanged += Materia1Cmb_SelectedIndexChanged;
            Materia2Cmb.SelectedIndexChanged += Materia2Cmb_SelectedIndexChanged;
            Materia3Cmb.SelectedIndexChanged += Materia3Cmb_SelectedIndexChanged;

            Curso1Cmb.SelectedIndexChanged += CursoCmb_SelectedIndexChanged;
            Curso2Cmb.SelectedIndexChanged += CursoCmb_SelectedIndexChanged;
            Curso3Cmb.SelectedIndexChanged += CursoCmb_SelectedIndexChanged;
        }
        private void InscripcionMaterias_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    var carreras = modelo.ObtenerCarreras() ?? new List<CarreraResponse>();
            //    var carrerasDelAlumno = carreras.Where(c => alumno.carrerasIds != null && alumno.carrerasIds.Contains(c.id)).ToList();

            //    CarreraCmb.Items.Clear();

            //    foreach (var carrera in carrerasDelAlumno)
            //    {
            //        CarreraCmb.Items.Add(carrera.nombre);
            //    }

            //    if (CarreraCmb.Items.Count > 0)
            //        CarreraCmb.SelectedIndex = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error cargando carreras: " + ex.Message);
            //}

            CargarMateriasHabilitadas();

            double ranking = modelo.calcularRanking(alumno.id);
            rankingListView.Items.Clear();
            ListViewItem item = new ListViewItem(ranking.ToString("0.##"));
            rankingListView.Items.Add(item);

            Curso1Cmb.Enabled = false;
            Curso2Cmb.Enabled = false;
            Curso3Cmb.Enabled = false;

            if (materiasHabilitadas == null || materiasHabilitadas.Count == 0)
            {
                MessageBox.Show("No tiene materias disponibles para inscribirse.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Materia1Cmb.Enabled = false;
                Materia2Cmb.Enabled = false;
                Materia3Cmb.Enabled = false;
                EnviarBtn.Enabled = false;

                return;
            }

        }

        private void CargarMateriasHabilitadas()
        {
            materiasHabilitadas.Clear();

            var carreras = modelo.ObtenerCarreras();
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
        private void Materia1Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos(Materia1Cmb, Curso1Cmb, cursos1, materiasHabilitadas);
        }
        private void Materia2Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos(Materia2Cmb, Curso2Cmb, cursos2, materiasHabilitadas);
        }
        private void Materia3Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos(Materia3Cmb, Curso3Cmb, cursos3, materiasHabilitadas);
        }
        private void CargarCursos(ComboBox materiaCmb, ComboBox cursoCmb, List<CursoResumenDTO> listaCursos, List<Materia> materiasHabilitadas)
        {
            int indexMateria = materiaCmb.SelectedIndex;
            if (indexMateria < 0)
            {
                cursoCmb.Items.Clear();
                cursoCmb.Enabled = false;
                listaCursos.Clear();
                return;
            }

            cursoCmb.Enabled = true;

            var materiaSeleccionada = materiasHabilitadas[indexMateria];
            var cursos = modelo.ObtenerCursosPorMateria(materiaSeleccionada.id)
                               .GroupBy(c => c.id)
                               .Select(g => g.First())
                               .ToList();

            listaCursos.Clear();
            listaCursos.AddRange(cursos);

            cursoCmb.Items.Clear();
            foreach (var curso in cursos)
            {
                cursoCmb.Items.Add(FormatearCurso(curso));
            }
        }

        private string FormatearCurso(CursoResumenDTO curso)
        {
            if (curso.horarios == null || curso.horarios.Count == 0)
                return "Sin horarios";

            var dias = curso.horarios.Select(h => h.dia).Distinct();
            var horario = curso.horarios.First();

            string diasString = string.Join(" - ", dias);
            string horarioString = $"{horario.horaInicio} - {horario.horaFin}";

            return $"{diasString} ({horarioString})";
        }

        private void CursoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox == null) return;

            int indexSeleccionado = comboBox.SelectedIndex;
            if (indexSeleccionado < 0) return;

            // Saber qué lista de cursos corresponde a este ComboBox
            List<CursoResumenDTO> listaCursos = null;
            if (comboBox == Curso1Cmb) listaCursos = cursos1;
            else if (comboBox == Curso2Cmb) listaCursos = cursos2;
            else if (comboBox == Curso3Cmb) listaCursos = cursos3;

            if (listaCursos == null) return;

            CursoResumenDTO cursoSeleccionado = listaCursos[indexSeleccionado];

            VerificarYAgregarCurso(cursoSeleccionado, comboBox);
        }
        private void VerificarYAgregarCurso(CursoResumenDTO cursoSeleccionado, ComboBox comboBox)
        {
            foreach (var cursoExistente in cursosSeleccionados)
            {
                if (HaySuperposicionHoraria(cursoExistente, cursoSeleccionado))
                {
                    MessageBox.Show("El curso seleccionado se superpone con otro ya elegido.");
                    comboBox.SelectedIndex = -1; // Borra la selección
                    return;
                }
            }

            cursosSeleccionados.Add(cursoSeleccionado);
        }
        private bool HaySuperposicionHoraria(CursoResumenDTO cursoExistente, CursoResumenDTO cursoNuevo)
        {
            foreach (var h1 in cursoExistente.horarios)
            {
                foreach (var h2 in cursoNuevo.horarios)
                {
                    if (h1.dia == h2.dia)
                    {
                        if (!(h2.horaFin.CompareTo(h1.horaInicio) <= 0 || h2.horaInicio.CompareTo(h1.horaFin) >= 0))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
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

            try
            {                
                modelo.InscribirAlumnoAMaterias(alumno.id, ids);

                string mensaje = "Materias seleccionadas (IDs): " + string.Join(", ", ids);
                MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inscribir materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void AtrasInscMatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAlumno menuAlumno = new MenuAlumno(alumno.id);
            menuAlumno.Show();
        }

    }
}

