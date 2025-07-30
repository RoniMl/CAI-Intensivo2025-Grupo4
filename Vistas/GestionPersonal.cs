using CAI_Intensivo2025_Grupo4.Vistas;
using Datos;
using Negocio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class GestionPersonal : Form
    {

        private GestionarPersonalNegocio negocio = new GestionarPersonalNegocio();
        private List<Materia> listaMaterias = new List<Materia>();
        private List<CursoResumenDTO> listaCursos = new List<CursoResumenDTO>();
        public GestionPersonal()
        {
            InitializeComponent();

            this.Load += GestionPersonal_Load;
            

        }

        private void GestionPersonal_Load(object sender, EventArgs e)
        {
            ActivarEdicion(false);

            NuevoDocenteBtn.Click += NuevoDocenteBtn_Click;
            CancelarGroupbtn.Click += CancelarGroupbtn_Click;
            AceptarGroupbtn.Click += AceptarGroupbtn_Click;
            EditarBtn.Click += EditarBtn_Click;
            BuscarBtn.Click += BuscarBtn_Click;
            EliminarBtn.Click += EliminarBtn_Click;

            PersonalListView.SelectedIndexChanged += PersonalListView_SelectedIndexChanged;

            // Inicialmente los botones Editar y Eliminar deshabilitados
            EditarBtn.Enabled = false;
            EliminarBtn.Enabled = false;

            // Cargar las materias en el ComboBox
            //foreach (var nombre in negocio.Materias().Select(m => m.nombre))
            //{
            //    MateriasGroupCmb.Items.Add(nombre);
            //}
            listaMaterias = negocio.Materias();
            foreach (var materia in listaMaterias)
            {
                MateriasGroupCmb.Items.Add(materia.nombre); 
            }

            MateriasGroupCmb.SelectedIndex = -1; // Ninguna seleccionada inicialmente
            MateriasGroupCmb.SelectedIndexChanged += MateriasGroupCmb_SelectedIndexChanged;


            TipoDocenteGroupCmb.Items.Clear();
            TipoDocenteGroupCmb.Items.Add("PROFESOR");
            TipoDocenteGroupCmb.Items.Add("AYUDANTE");
            TipoDocenteGroupCmb.Items.Add("AYUDANTE_AD_HONOREM");
        }

        private void ActivarEdicion(bool activar)
        {
            EdicionGroup.Enabled = activar;

            BuscarDniTxb.Enabled = !activar;
            BuscarBtn.Enabled = !activar;
            PersonalListView.Enabled = !activar;
            NuevoDocenteBtn.Enabled = !activar;
            EditarBtn.Enabled = !activar;
            EliminarBtn.Enabled = !activar;
        }

        private void LimpiarCampos()
        {
            IdGroupTxb.Text = "";
            NombreGroupTxb.Text = "";
            ApellidoGroupTxb.Text = "";
            DniGroupTxb.Text = "";
            MateriasGroupCmb.SelectedIndex = -1;
            MatAsignadasGroupListView.Items.Clear();
        }

        private void NuevoDocenteBtn_Click(object sender, EventArgs e)
        {
            // Abrir el formulario CrearPersonal
            CrearPersonal crearPersonalForm = new CrearPersonal();
            crearPersonalForm.ShowDialog();

            // Opcional: recargar lista de personal después de crear nuevo
            // CargarPersonal(); // método que tengas para refrescar la lista
        }

        private void CancelarGroupbtn_Click(object sender, EventArgs e)
        {
            ActivarEdicion(false);
            LimpiarCampos();
        }

        public void BuscarBtn_Click(object sender, EventArgs e)
        {
            string dni = BuscarDniTxb.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar.");
                return;
            }

            try
            {
                // Llama a la capa negocio para obtener el docente por dni
                var docente = negocio.ObtenerDocentePorDni(dni);

                // Limpia la lista antes de mostrar resultados
                PersonalListView.Clear();

                // Configura las columnas (títulos)
                PersonalListView.View = View.Details;
                PersonalListView.Columns.Add("ID", 50);
                PersonalListView.Columns.Add("Nombre", 150);
                PersonalListView.Columns.Add("Apellido", 150);
                PersonalListView.Columns.Add("DNI", 100);
                PersonalListView.Columns.Add("Tipo de docente", 120);

                if (docente != null)
                {
                    // Crea el ítem con la info del docente
                    ListViewItem item = new ListViewItem(docente.id.ToString());
                    item.SubItems.Add(docente.nombre);
                    item.SubItems.Add(docente.apellido);
                    item.SubItems.Add(docente.dni);
                    item.SubItems.Add(docente.tipo);

                    PersonalListView.Items.Add(item);
                  
                }
                else
                {
                    MessageBox.Show("No se encontró ningún docente con ese DNI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar docente: " + ex.Message);
            }
        }

        private void PersonalListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool tieneSeleccion = PersonalListView.SelectedItems.Count > 0;
            EditarBtn.Enabled = tieneSeleccion;
            EliminarBtn.Enabled = tieneSeleccion;
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (PersonalListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un docente para eliminar.");
                return;
            }

            var item = PersonalListView.SelectedItems[0];
            int idDocente = int.Parse(item.SubItems[0].Text);

            try
            {
                bool eliminado = negocio.EliminarDocentePorId(idDocente);
                if (eliminado)
                {
                    MessageBox.Show("Docente eliminado con éxito.");
                    // Recargar lista o limpiar
                    BuscarBtn_Click(null, null); // o el método que uses para refrescar la lista
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el docente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar docente: " + ex.Message);
            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (PersonalListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un docente para editar.");
                return;
            }

            var item = PersonalListView.SelectedItems[0];

            // Asignar valores desde el ListView (ajustar según columnas)
            IdGroupTxb.Text = item.SubItems[0].Text;
            NombreGroupTxb.Text = item.SubItems[1].Text;
            ApellidoGroupTxb.Text = item.SubItems[2].Text;
            DniGroupTxb.Text = item.SubItems[3].Text;
            TipoDocenteGroupCmb.SelectedItem = item.SubItems[4].Text;
            
            IdGroupTxb.Enabled = false;

            
            int idDocente = int.Parse(IdGroupTxb.Text);
            CargarCursosAsignadosEnListView(idDocente);

            ActivarEdicion(true);
        }
        private void AceptarGroupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto docente con los datos modificados
                Docente docenteEditado = new Docente()
                {
                    id = int.Parse(IdGroupTxb.Text),
                    nombre = NombreGroupTxb.Text,
                    apellido = ApellidoGroupTxb.Text,
                    dni = DniGroupTxb.Text,
                    tipo = TipoDocenteGroupCmb.SelectedItem?.ToString() ?? ""
                    // Completar con otros campos si hace falta
                };

                // Guardar la edición en la capa negocio
                bool resultado = negocio.EditarDocente(docenteEditado);

                if (resultado)
                {
                    MessageBox.Show("Cambios guardados con éxito.");

                    // Refrescar el ListView con solo ese docente actualizado
                    PersonalListView.Items.Clear();

                    var item = new ListViewItem(docenteEditado.id.ToString());
                    item.SubItems.Add(docenteEditado.nombre);
                    item.SubItems.Add(docenteEditado.apellido);
                    item.SubItems.Add(docenteEditado.dni);
                    item.SubItems.Add(docenteEditado.tipo);

                    PersonalListView.Items.Add(item);

                    ActivarEdicion(false);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudieron guardar los cambios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MateriasGroupCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string materiaSeleccionada = MateriasGroupCmb.SelectedItem.ToString();

            Materia materia = listaMaterias.FirstOrDefault(m => m.nombre == materiaSeleccionada);

            if (materia != null)
            {
                int idMateria = materia.id;

                List<CursoResumenDTO> cursos = negocio.buscarCursos(idMateria);

                CargarCursosEnCombo(cursos);
            }

        }
        private string FormatearCurso(CursoResumenDTO curso)
        {
            var dias = curso.horarios.Select(h => h.dia).Distinct().ToList();

            // Tomar el primer horario como referencia
            var horario = curso.horarios.FirstOrDefault();

            if (horario == null)
                return "Sin horarios";

            // Armar el string final
            string diasString = string.Join(" - ", dias);
            string horarioString = $"{horario.horaInicio} - {horario.horaFin}";

            return $"{diasString} ({horarioString})";
        }
        private void CargarCursosEnCombo(List<CursoResumenDTO> cursos)
        {
            CursosComboBox.Items.Clear();
            listaCursos = cursos;

            foreach (var curso in cursos)
            {
                string texto = FormatearCurso(curso);
                CursosComboBox.Items.Add(texto); // Mostrás solo el texto formateado
            }
        }

        private void CargarCursosAsignadosEnListView(int idDocente)
        {
            var cursosAsignados = negocio.CursosAsignados(idDocente);

            foreach (var item in cursosAsignados)
            {
                string textoCurso = FormatearCurso(item.Curso); // Ya tienes este método para el formato días-horarios

                ListViewItem listItem = new ListViewItem(item.NombreMateria);
                listItem.SubItems.Add(textoCurso);

                MatAsignadasGroupListView.Items.Add(listItem);
            }
        }
    }
    
}
