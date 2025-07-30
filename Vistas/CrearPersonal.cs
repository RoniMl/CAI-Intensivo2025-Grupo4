using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class CrearPersonal : Form
    {
        public CrearPersonal()
        {
            InitializeComponent();
            this.Load += CrearPersonal_Load;

        }

        private List<Materia> listaMaterias = new List<Materia>();
        private List<CursoResumenDTO> listaCursos = new List<CursoResumenDTO>();
        private List<CursoResumenDTO> cursosAsignados = new List<CursoResumenDTO>();
        private GestionarPersonalNegocio negocio = new GestionarPersonalNegocio();

        private void CrearPersonal_Load(object sender, EventArgs e)
        {
            CargarMaterias();

            MateriasCmb.SelectedIndexChanged += MateriasCmb_SelectedIndexChanged;
            AgregarBtn.Click += AgregarBtn_Click;
            CrearPersonalBtn.Click += CrearPersonalBtn_Click;

            TipoCmb.Items.Clear();
            TipoCmb.Items.Add("PROFESOR");
            TipoCmb.Items.Add("AYUDANTE");
            TipoCmb.Items.Add("AYUDANTE_AD_HONOREM");

            CursosCmb.Enabled = false; // Hasta que elija materia
        }

        private void CargarMaterias()
        {
            listaMaterias = negocio.Materias();

            MateriasCmb.Items.Clear();

            foreach (var materia in listaMaterias)
            {
                MateriasCmb.Items.Add(materia.nombre);
            }
        }

        private void MateriasCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMateria = MateriasCmb.SelectedIndex;
            if (indexMateria < 0)
            {
                CursosCmb.Items.Clear();
                CursosCmb.Enabled = false;
                return;
            }

            var materiaSeleccionada = listaMaterias[indexMateria];
            listaCursos = negocio.buscarCursos(materiaSeleccionada.id);

            CursosCmb.Items.Clear();

            foreach (var curso in listaCursos)
            {
                CursosCmb.Items.Add(FormatearCurso(curso));
            }

            CursosCmb.Enabled = true;
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


        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            int indexCurso = CursosCmb.SelectedIndex;
            int indexMateria = MateriasCmb.SelectedIndex;

            if (indexMateria < 0 || indexCurso < 0)
            {
                MessageBox.Show("Seleccione materia y curso.");
                return;
            }

            var cursoSeleccionado = listaCursos[indexCurso];
            var materiaSeleccionada = listaMaterias[indexMateria];

            // Evitar duplicados por id de curso
            if (cursosAsignados.Any(c => c.id == cursoSeleccionado.id))
            {
                MessageBox.Show("El curso ya fue asignado.");
                return;
            }

            cursosAsignados.Add(cursoSeleccionado);

            RefrescarListViewCursosAsignados();
        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (CursosAsignadosListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in CursosAsignadosListView.SelectedItems)
                {
                    CursosAsignadosListView.Items.Remove(item);
                }
                RefrescarListViewCursosAsignados();
            }
            else
            {
                MessageBox.Show("Seleccioná un curso de la lista para quitarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefrescarListViewCursosAsignados()
        {
            CursosAsignadosListView.Items.Clear();

            foreach (var curso in cursosAsignados)
            {
                string textoCurso = FormatearCurso(curso);
                // Si querés también mostrar la materia podrías agregarla, pero acá solo el curso

                ListViewItem item = new ListViewItem(textoCurso);
                item.Tag = curso; // guardamos el curso para referencia futura
                CursosAsignadosListView.Items.Add(item);
            }
        }
        private async void CrearPersonalBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreTxb.Text) ||
                string.IsNullOrWhiteSpace(ApellidoTxb.Text) ||
                string.IsNullOrWhiteSpace(DniTxb.Text) ||
                TipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (cursosAsignados.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos un curso.");
                return;
            }

            var nuevoDocente = new Docente
            {
                nombre = NombreTxb.Text.Trim(),
                apellido = ApellidoTxb.Text.Trim(),
                cuit = CuitTxb.Text.Trim(),
                dni = DniTxb.Text.Trim(),
                tipo = TipoCmb.SelectedItem.ToString(),
                cursos = cursosAsignados.Select(c => c.id).ToList()
            };

            try
            {
                // Aquí llamarías a tu método negocio para POST, por ej:
                bool creado = negocio.CrearDocente(nuevoDocente);
                if (creado)
                {
                    MessageBox.Show("Docente creado correctamente.");
                    LimpiarCampos();
                    cursosAsignados.Clear();
                    RefrescarListViewCursosAsignados();
                }
                else
                {
                    MessageBox.Show("Error al crear docente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            NombreTxb.Text = "";
            ApellidoTxb.Text = "";
            CuitTxb.Text = "";
            DniTxb.Text = "";

            MateriasCmb.SelectedIndex = -1;
            CursosCmb.SelectedIndex = -1;

            cursosAsignados.Clear();
            CursosAsignadosListView.Items.Clear();
        }
    }
}
