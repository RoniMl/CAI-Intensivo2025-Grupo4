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
        private List<CursoAsignado> cursosAsignados = new List<CursoAsignado>();
        private GestionarPersonalNegocio negocio = new GestionarPersonalNegocio();

        private void CrearPersonal_Load(object sender, EventArgs e)
        {
            CargarMaterias();

            MateriasCmb.SelectedIndexChanged += MateriasCmb_SelectedIndexChanged;                       

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
            if (cursosAsignados.Any(c => c.Curso.id == cursoSeleccionado.id))
            {
                MessageBox.Show("El curso ya fue asignado.");
                return;
            }            

            if (TieneSuperposicionHoraria(cursoSeleccionado))
            {
                MessageBox.Show("El curso tiene un horario que se superpone con otro ya asignado.");
                return;
            }

            cursosAsignados.Add(new CursoAsignado
            {
                NombreMateria = materiaSeleccionada.nombre,
                Curso = cursoSeleccionado
            });

            RefrescarListViewCursosAsignados();

            CursosCmb.SelectedIndex = -1;
        }

        private bool TieneSuperposicionHoraria(CursoResumenDTO nuevoCurso)
        {
            foreach (var cursoAsignado in cursosAsignados)
            {
                foreach (var h1 in cursoAsignado.Curso.horarios)
                {
                    foreach (var h2 in nuevoCurso.horarios)
                    {
                        if (h1.dia == h2.dia)
                        {
                            // No hay superposición si el nuevo curso termina antes que empiece el asignado
                            // o si el nuevo curso empieza después que termine el asignado
                            if (!(h2.horaFin.CompareTo(h1.horaInicio) <= 0 || h2.horaInicio.CompareTo(h1.horaFin) >= 0))
                            {
                                return true; // Superposición detectada
                            }
                        }
                    }
                }
            }
            return false; // No hay superposición
        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (CursosAsignadosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un curso para quitar.");
                return;
            }

            // Tomamos el primer ítem seleccionado (si querés podés hacer un foreach para eliminar varios)
            var itemSeleccionado = CursosAsignadosListView.SelectedItems[0];

            string nombreMateria = itemSeleccionado.SubItems[0].Text;
            string cursoTexto = itemSeleccionado.SubItems[1].Text;

            var cursoAEliminar = cursosAsignados.FirstOrDefault(ca =>ca.NombreMateria == nombreMateria && FormatearCurso(ca.Curso) == cursoTexto);

            if (cursoAEliminar != null)
            {
                cursosAsignados.Remove(cursoAEliminar);
                RefrescarListViewCursosAsignados();
            }
        }
        private void RefrescarListViewCursosAsignados()
        {
            CursosAsignadosListView.Items.Clear();
            

            foreach (var item in cursosAsignados)
            {
                var listItem = new ListViewItem(item.NombreMateria);
                listItem.SubItems.Add(FormatearCurso(item.Curso));
                CursosAsignadosListView.Items.Add(listItem);
            }
        }
        private async void CrearPersonalBtn_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(NombreTxb.Text) ||
                string.IsNullOrWhiteSpace(ApellidoTxb.Text) ||
                string.IsNullOrWhiteSpace(Cuit1Txb.Text) ||
                string.IsNullOrWhiteSpace(Cuit2Txb.Text) ||
                string.IsNullOrWhiteSpace(Cuit3Txb.Text) ||
                TipoCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            // Validar que nombre y apellido no tengan números usando regex
            var regexSoloLetras = new System.Text.RegularExpressions.Regex("^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$");
            if (!regexSoloLetras.IsMatch(NombreTxb.Text.Trim()))
            {
                MessageBox.Show("El nombre sólo puede contener letras y espacios.");
                return;
            }
            if (!regexSoloLetras.IsMatch(ApellidoTxb.Text.Trim()))
            {
                MessageBox.Show("El apellido sólo puede contener letras y espacios.");
                return;
            }

            // Validar que CUIT sólo tenga números en cada parte
            if (!Cuit1Txb.Text.All(char.IsDigit) ||
                !Cuit2Txb.Text.All(char.IsDigit) ||
                !Cuit3Txb.Text.All(char.IsDigit))
            {
                MessageBox.Show("El CUIT debe contener sólo números.");
                return;
            }

            // Validar longitud CUIT
            if (Cuit1Txb.Text.Length != 2 || Cuit2Txb.Text.Length != 8 || Cuit3Txb.Text.Length != 1)
            {
                MessageBox.Show("CUIT inválido. Debe tener formato XX-XXXXXXXX-X");
                return;
            }

            // Construcción del CUIT y DNI
            string cuit = $"{Cuit1Txb.Text}-{Cuit2Txb.Text}-{Cuit3Txb.Text}";
            string dni = Cuit2Txb.Text;

            if (cursosAsignados.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos un curso.");
                return;
            }

            var nuevoDocente = new Docente
            {
                nombre = NombreTxb.Text.Trim(),
                apellido = ApellidoTxb.Text.Trim(),
                cuit = cuit,
                dni = dni,
                tipo = TipoCmb.SelectedItem.ToString(),
                cursos = cursosAsignados.Select(c => c.Curso.id).ToList()
            };

            string mensaje = $"{{\n" +
                 $"  \"nombre\": \"{nuevoDocente.nombre}\",\n" +
                 $"  \"apellido\": \"{nuevoDocente.apellido}\",\n" +
                 $"  \"cuit\": \"{nuevoDocente.cuit}\",\n" +
                 $"  \"dni\": \"{nuevoDocente.dni}\",\n" +
                 $"  \"tipo\": \"{nuevoDocente.tipo}\",\n" +
                 $"  \"cursos\": [{string.Join(", ", nuevoDocente.cursos)}]\n" +
                 $"}}";

            MessageBox.Show(mensaje, "Docente a crear (Preview)");

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
            Cuit1Txb.Text = "";
            Cuit2Txb.Text = "";
            Cuit3Txb.Text = "";
            TipoCmb.SelectedIndex = -1;

            MateriasCmb.SelectedIndex = -1;            

            cursosAsignados.Clear();
            CursosAsignadosListView.Items.Clear();
        }
    }
}
