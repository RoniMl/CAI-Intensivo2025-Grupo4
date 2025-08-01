using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class CrearAlumno : Form
    {
        
        private GestionarAlumnosNegocio negocio = new GestionarAlumnosNegocio();
        private List<CarreraResponse> carrerasDisponibles = new List<CarreraResponse>();
        private List<CarreraResponse> carrerasAsignadas = new List<CarreraResponse>();
        public CrearAlumno()
        {
            InitializeComponent();
            this.Load += CrearAlumno_Load;
        }

        private void CrearAlumno_Load(object sender, EventArgs e)
        {
            carrerasDisponibles = negocio.Carreras(); 
            CarreraCmb.Items.Clear();
            foreach (var carrera in carrerasDisponibles)
                CarreraCmb.Items.Add(carrera.nombre);
        }

        private void CrearAlumnoBtn_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(NombreTxb.Text) ||
                string.IsNullOrWhiteSpace(ApellidoTxb.Text) ||
                string.IsNullOrWhiteSpace(DniTxb.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            // Validación: nombre y apellido solo letras
            var regexLetras = new Regex("^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$");
            if (!regexLetras.IsMatch(NombreTxb.Text.Trim()))
            {
                MessageBox.Show("El nombre solo puede contener letras.");
                return;
            }

            if (!regexLetras.IsMatch(ApellidoTxb.Text.Trim()))
            {
                MessageBox.Show("El apellido solo puede contener letras.");
                return;
            }

            // Validar DNI
            if (!DniTxb.Text.All(char.IsDigit) || DniTxb.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe contener 8 dígitos numéricos.");
                return;
            }

            // Validar carreras asignadas
            if (carrerasAsignadas.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos una carrera.");
                return;
            }

            var alumno = new Alumno
            {
                nombre = NombreTxb.Text.Trim(),
                apellido = ApellidoTxb.Text.Trim(),
                dni = DniTxb.Text.Trim(),
                carrerasIds = carrerasAsignadas.Select(c => c.id).ToList()
            };

            try
            {
                string previewCrear = "{\n" +
    $"  \"nombre\": \"{alumno.nombre}\",\n" +
    $"  \"apellido\": \"{alumno.apellido}\",\n" +
    $"  \"dni\": \"{alumno.dni}\",\n" +
    $"  \"carrerasIds\": [{string.Join(", ", alumno.carrerasIds)}]\n" +
    "}";
                MessageBox.Show(previewCrear, "Alumno a crear (preview)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool creado = negocio.CrearAlumno(alumno);
                if (creado)
                {
                    MessageBox.Show("Alumno creado exitosamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al crear el alumno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }

        private void AñadirBtn_Click(object sender, EventArgs e)
        {
            int index = CarreraCmb.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Seleccione una carrera para agregar.");
                return;
            }

            var carrera = carrerasDisponibles[index];

            if (carrerasAsignadas.Any(c => c.id == carrera.id))
            {
                MessageBox.Show("La carrera ya fue asignada.");
                return;
            }

            carrerasAsignadas.Add(carrera);
            RefrescarListViewCarreras();
        }

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (CarreraListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una carrera para quitar.");
                return;
            }

            var nombreCarrera = CarreraListView.SelectedItems[0].Text;
            var carrera = carrerasAsignadas.FirstOrDefault(c => c.nombre == nombreCarrera);

            if (carrera != null)
            {
                carrerasAsignadas.Remove(carrera);
                RefrescarListViewCarreras();
            }
        }

        private void RefrescarListViewCarreras()
        {
            CarreraListView.Items.Clear();
            foreach (var c in carrerasAsignadas)
            {
                var item = new ListViewItem(c.nombre);
                CarreraListView.Items.Add(item);
            }
        }

        private void LimpiarCampos()
        {
            NombreTxb.Clear();
            ApellidoTxb.Clear();
            DniTxb.Clear();
            CarreraCmb.SelectedIndex = -1;
            carrerasAsignadas.Clear();
            CarreraListView.Items.Clear();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
