using CAI_Intensivo2025_Grupo4.Vistas;
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
        public GestionPersonal()
        {
            InitializeComponent();

            ActivarEdicion(false);

            NuevoDocenteBtn.Click += NuevoDocenteBtn_Click;
            CancelarGroupbtn.Click += CancelarGroupbtn_Click;
            AceptarGroupbtn.Click += AceptarGroupbtn_Click;
            EditarBtn.Click += EditarBtn_Click;
            BuscarBtn.Click += BuscarBtn_Click;

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

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            string dni = BuscarDniTxb.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar.");
                return;
            }

            // TODO: Buscar personal y mostrar resultados en PersonalListView
            MessageBox.Show($"Buscar por DNI: {dni}");
        }

        private void PersonalListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool tieneSeleccion = PersonalListView.SelectedItems.Count > 0;
            EditarBtn.Enabled = tieneSeleccion;
            EliminarBtn.Enabled = tieneSeleccion;
        }

    }
    
}
