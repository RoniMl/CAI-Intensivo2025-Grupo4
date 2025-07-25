using CAI_Intensivo2025_Grupo4.Vistas;
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

namespace Vistas
{
    public partial class GestionPersonal : Form
    {

        private GestionarPersonalNegocio negocio = new GestionarPersonalNegocio();
        public GestionPersonal()
        {
            InitializeComponent();

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

        private void AceptarGroupbtn_Click(object sender, EventArgs e)
        {
            // Guardar cambios en la edición
            // TODO: Implementar lógica de guardado aquí

            MessageBox.Show("Cambios guardados con éxito.");

            ActivarEdicion(false);
            LimpiarCampos();

            // Opcional: recargar lista
            // CargarPersonal();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
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

                if (docente != null)
                {
                    // Crea el ítem con la info del docente
                    ListViewItem item = new ListViewItem(docente.id.ToString());
                    item.SubItems.Add(docente.nombre);
                    item.SubItems.Add(docente.apellido);
                    item.SubItems.Add(docente.dni);

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

            IdGroupTxb.Enabled = false;

            ActivarEdicion(true);
        }

    }
    
}
