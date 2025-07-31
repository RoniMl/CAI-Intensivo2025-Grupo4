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
        private List<CursoAsignado> cursosAsignados = new List<CursoAsignado>();
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

            CargarMaterias();

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
                PersonalListView.Columns.Add("CUIT", 110);
                PersonalListView.Columns.Add("Tipo de docente", 180);

                if (docente != null)
                {
                    // Crea el ítem con la info del docente
                    ListViewItem item = new ListViewItem(docente.id.ToString());
                    item.SubItems.Add(docente.nombre);
                    item.SubItems.Add(docente.apellido);
                    item.SubItems.Add(docente.dni);
                    item.SubItems.Add(docente.cuit);
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

            string mensaje = $"Va a eliminar al docente con ID: {idDocente}\n" +
                     $"Nombre: {item.SubItems[1].Text}\n" +
                     $"Apellido: {item.SubItems[2].Text}\n" +
                     $"DNI: {item.SubItems[3].Text}\n" +
                     $"Tipo: {item.SubItems[4].Text}";

            MessageBox.Show(mensaje, "Verificación antes de eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void CargarMaterias()
        {
            listaMaterias = negocio.Materias(); // o el método que uses para traer las materias

            MateriasGroupCmb.Items.Clear();

            foreach (var materia in listaMaterias)
            {
                MateriasGroupCmb.Items.Add(materia.nombre);
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
            Cuit1GroupTxb.Text = item.SubItems[4].Text;
            TipoDocenteGroupCmb.SelectedItem = item.SubItems[5].Text;

            IdGroupTxb.Enabled = false;


            int idDocente = int.Parse(IdGroupTxb.Text);
            CargarCursosAsignadosEnListView(idDocente);

            ActivarEdicion(true);
        }
        private void AceptarGroupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (!ValidarCamposObligatorios()) return;
                if (!ValidarNombreApellido()) return;
                if (!ValidarCUIT()) return;


                if (cursosAsignados.Count == 0)
                {
                    MessageBox.Show("Debe asignar al menos un curso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cuit = $"{Cuit1GroupTxb.Text}-{Cuit2GroupTxb.Text}-{Cuit3GroupTxb.Text}";
                string dni = Cuit2GroupTxb.Text;


                // Crear el objeto docente con los datos modificados
                Docente docenteEditado = new Docente()
                {
                    id = int.Parse(IdGroupTxb.Text),
                    nombre = NombreGroupTxb.Text,
                    apellido = ApellidoGroupTxb.Text,
                    dni = dni,
                    cuit = cuit,
                    tipo = TipoDocenteGroupCmb.SelectedItem?.ToString() ?? "",
                    cursos = cursosAsignados.Select(ca => ca.Curso.id).ToList()
                };

                //MENSAJE DE PRUEBA  PARA VER QUE SE ENVIA EN EL PUT
                string cursosTexto = string.Join(", ", docenteEditado.cursos);
                string mensaje = $"ID: {docenteEditado.id}\n" +
                                 $"Nombre: {docenteEditado.nombre}\n" +
                                 $"Apellido: {docenteEditado.apellido}\n" +
                                 $"DNI: {docenteEditado.dni}\n" +
                                 $"CUIT: {docenteEditado.cuit}\n" +
                                 $"Tipo: {docenteEditado.tipo}\n" +
                                 $"Cursos: {cursosTexto}";

                MessageBox.Show(mensaje, "Datos a enviar (Edición)", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int indexMateria = MateriasGroupCmb.SelectedIndex;
            if (indexMateria < 0) return;

            var materiaSeleccionada = listaMaterias[indexMateria];
            listaCursos = negocio.buscarCursos(materiaSeleccionada.id);

            // Evitás duplicados por ID de curso
            listaCursos = listaCursos.GroupBy(c => c.id).Select(g => g.First()).ToList();

            CursosComboBox.Items.Clear();
            foreach (var curso in listaCursos)
            {
                CursosComboBox.Items.Add(FormatearCurso(curso));
            }

        }
        //private void CargarCursosEnCombo(List<CursoResumenDTO> cursos)
        //{
        //    CursosComboBox.Items.Clear();
        //    listaCursos = cursos;

        //    foreach (var curso in cursos)
        //    {
        //        string texto = FormatearCurso(curso);
        //        CursosComboBox.Items.Add(texto); // Mostrás solo el texto formateado
        //    }
        //}
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


        private void CargarCursosAsignadosEnListView(int idDocente)
        {
            cursosAsignados = negocio.CursosAsignados(idDocente);

            var cursosUnicos = cursosAsignados
             .DistinctBy(c => (c.NombreMateria, c.Curso.id))
             .ToList();

            foreach (var item in cursosUnicos)
            {
                string textoCurso = FormatearCurso(item.Curso); // Ya tienes este método para el formato días-horarios

                ListViewItem listItem = new ListViewItem(item.NombreMateria);
                listItem.SubItems.Add(textoCurso);

                MatAsignadasGroupListView.Items.Add(listItem);
            }
        }

        private void AgregarGroupBtn_Click(object sender, EventArgs e)
        {

            int indexMateria = MateriasGroupCmb.SelectedIndex;
            int indexCurso = CursosComboBox.SelectedIndex;

            if (indexMateria < 0 || indexCurso < 0)
            {
                MessageBox.Show("Seleccioná una materia y un curso.");
                return;
            }

            var materiaSeleccionada = listaMaterias[indexMateria];
            var cursoSeleccionado = listaCursos[indexCurso];

            foreach (var cursoAsignado in cursosAsignados)
            {
                if (HaySuperposicionHoraria(cursoAsignado.Curso, cursoSeleccionado))
                {
                    MessageBox.Show("No se puede agregar el curso porque se superpone con otro asignado.");
                    return;
                }
            }

            // Evitar duplicados
            if (cursosAsignados.Any(c => c.Curso.id == cursoSeleccionado.id))
            {
                MessageBox.Show("Este curso ya está asignado.");
                return;
            }



            cursosAsignados.Add(new CursoAsignado
            {
                NombreMateria = materiaSeleccionada.nombre,
                Curso = cursoSeleccionado
            });

            RefrescarListViewCursosAsignados();
        }
        private bool HaySuperposicionHoraria(CursoResumenDTO cursoExistente, CursoResumenDTO cursoNuevo)
        {
            foreach (var h1 in cursoExistente.horarios)
            {
                foreach (var h2 in cursoNuevo.horarios)
                {
                    // Si coinciden los días
                    if (h1.dia == h2.dia)
                    {
                        // Comparación de strings de hora para verificar superposición
                        // No hay superposición si el horario nuevo termina antes que empiece el existente
                        // o si el horario nuevo empieza después que termine el existente
                        if (!(h2.horaFin.CompareTo(h1.horaInicio) <= 0 || h2.horaInicio.CompareTo(h1.horaFin) >= 0))
                        {
                            return true; // Sí hay superposición
                        }
                    }
                }
            }
            return false; // No hay superposición
        }
        private void RefrescarListViewCursosAsignados()
        {
            MatAsignadasGroupListView.Items.Clear();

            foreach (var item in cursosAsignados)
            {
                var listItem = new ListViewItem(item.NombreMateria);
                listItem.SubItems.Add(FormatearCurso(item.Curso));
                MatAsignadasGroupListView.Items.Add(listItem);
            }
        }

        private void QuitarGroupBtn_Click(object sender, EventArgs e)
        {
            if (MatAsignadasGroupListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un curso para quitar.");
                return;
            }

            // Obtengo el primer item seleccionado
            var itemSeleccionado = MatAsignadasGroupListView.SelectedItems[0];

            // NombreMateria está en la primera columna
            string nombreMateria = itemSeleccionado.SubItems[0].Text;
            // Para identificar el curso, usamos el texto formateado que está en la segunda columna
            string cursoTexto = itemSeleccionado.SubItems[1].Text;

            // Buscamos el CursoAsignado en la lista cursosAsignados que coincida
            var cursoAEliminar = cursosAsignados.FirstOrDefault(ca => ca.NombreMateria == nombreMateria && FormatearCurso(ca.Curso) == cursoTexto);

            if (cursoAEliminar != null)
            {
                cursosAsignados.Remove(cursoAEliminar);
                RefrescarListViewCursosAsignados();
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(NombreGroupTxb.Text) ||
                string.IsNullOrWhiteSpace(ApellidoGroupTxb.Text) ||
                string.IsNullOrWhiteSpace(Cuit1GroupTxb.Text) ||
                string.IsNullOrWhiteSpace(Cuit2GroupTxb.Text) ||
                string.IsNullOrWhiteSpace(Cuit3GroupTxb.Text) ||
                TipoDocenteGroupCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarNombreApellido()
        {
            var regex = new System.Text.RegularExpressions.Regex("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$");
            if (!regex.IsMatch(NombreGroupTxb.Text.Trim()) || !regex.IsMatch(ApellidoGroupTxb.Text.Trim()))
            {
                MessageBox.Show("Nombre y Apellido sólo deben contener letras y espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarCUIT()
        {
            var regexCuit = new System.Text.RegularExpressions.Regex("^[0-9]{2}$");
            var regexDni = new System.Text.RegularExpressions.Regex("^[0-9]{8}$");
            var regexVerificador = new System.Text.RegularExpressions.Regex("^[0-9]{1}$");

            if (Cuit1GroupTxb.Text.Length != 2 || Cuit2GroupTxb.Text.Length != 8 || Cuit3GroupTxb.Text.Length != 1)
            {
                MessageBox.Show("CUIT inválido. Debe tener formato XX-XXXXXXXX-X", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!regexCuit.IsMatch(Cuit1GroupTxb.Text) ||
                !regexDni.IsMatch(Cuit2GroupTxb.Text) ||
                !regexVerificador.IsMatch(Cuit3GroupTxb.Text))
            {
                MessageBox.Show("CUIT debe contener sólo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdmin = new MenuAdministrador();
            menuAdmin.Show();
                        
            this.Close();
        }
    }

}
