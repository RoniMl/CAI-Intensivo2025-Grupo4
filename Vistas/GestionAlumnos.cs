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
    public partial class GestionAlumnos : Form
    {
        private GestionarAlumnosNegocio negocio = new GestionarAlumnosNegocio();
        private List<CarreraResponse> listaCarreras = new List<CarreraResponse>();
        private List<CarreraResponse> carrerasAsignadas = new List<CarreraResponse>();
        public GestionAlumnos()
        {
            InitializeComponent();
            this.Load += GestionAlumnos_Load;
        }
        private void GestionAlumnos_Load(object sender, EventArgs e)
        {
            ActivarEdicion(false);

            AlumnosListView.SelectedIndexChanged += AlumnosListView_SelectedIndexChanged;

            EditarBtn.Enabled = false;
            EliminarBtn.Enabled = false;
            


            CargarCarreras();
        }

        private void ActivarEdicion(bool activar)
        {
            EdicionGroup.Enabled = activar;

            BuscarDniTxb.Enabled = !activar;
            BuscarBtn.Enabled = !activar;
            AlumnosListView.Enabled = !activar;
            NuevoAlumnoBtn.Enabled = !activar;
            EditarBtn.Enabled = !activar;
            EliminarBtn.Enabled = !activar;
            AtrasBtn.Enabled = !activar;
        }

        private void LimpiarCampos()
        {
            IdGrpTxb.Text = "";
            NombreGrpTxb.Text = "";
            ApellidoGrpTxb.Text = "";
            DniGrpTxb.Text = "";
            CarrerasGrpListView.Items.Clear();
            CarrerasGrpCmb.SelectedIndex = -1;
            CarrerasGrpListView.Items.Clear();
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
                var alumno = negocio.BuscarAlumnoPorDni(dni);

                AlumnosListView.Items.Clear();


                if (alumno != null)
                {
                    // Crea el ítem con la info del docente
                    ListViewItem item = new ListViewItem(alumno.id.ToString());
                    item.SubItems.Add(alumno.nombre);
                    item.SubItems.Add(alumno.apellido);
                    item.SubItems.Add(alumno.dni);

                    AlumnosListView.Items.Add(item);

                }
                else
                {
                    MessageBox.Show("No se encontró ningún alumno con ese DNI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar alumno: " + ex.Message);
            }

        }

        private void AlumnosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool tieneSeleccion = AlumnosListView.SelectedItems.Count > 0;
            EditarBtn.Enabled = tieneSeleccion;
            EliminarBtn.Enabled = tieneSeleccion;
        }

        private void NuevoAlumnoBtn_Click(object sender, EventArgs e)
        {
            var crearAlumno = new CrearAlumno();
            crearAlumno.ShowDialog();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (AlumnosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un Alumno para editar.");
                return;
            }

            var item = AlumnosListView.SelectedItems[0];

            int idAlumno = int.Parse(item.SubItems[0].Text); 

            try
            {
                IdGrpTxb.Text = item.SubItems[0].Text;
                NombreGrpTxb.Text = item.SubItems[1].Text;
                ApellidoGrpTxb.Text = item.SubItems[2].Text;
                DniGrpTxb.Text = item.SubItems[3].Text;

                IdGrpTxb.Enabled = false;

                CargarCarrerasAsignadasEnListView(idAlumno);
                ActivarEdicion(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el alumno para edición: " + ex.Message);
            }

            ActivarEdicion(true);

        }

        private void CargarCarrerasAsignadasEnListView(int idAlumno)
        {
            try
            {
                var carreras = negocio.CarrerasAsignadasAlumno(idAlumno);

                CarrerasGrpListView.Items.Clear();
                carrerasAsignadas.Clear(); 

                foreach (var carrera in carreras)
                {
                    var item = new ListViewItem(carrera.nombre);
                    item.Tag = carrera.id;
                    CarrerasGrpListView.Items.Add(item);

                    carrerasAsignadas.Add(carrera);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCarreras()
        {
            listaCarreras = negocio.Carreras(); 
            CarrerasGrpCmb.Items.Clear();

            foreach (var carrera in listaCarreras)
            {
                CarrerasGrpCmb.Items.Add(carrera.nombre);
            }
        }

        private void AgregarGrpBtn_Click(object sender, EventArgs e)
        {
            int indexCarrera = CarrerasGrpCmb.SelectedIndex;

            if (indexCarrera < 0)
            {
                MessageBox.Show("Seleccioná una carrera.");
                return;
            }

            var carreraSeleccionada = listaCarreras[indexCarrera]; // agarro el objeto por índice

            if (carrerasAsignadas.Any(c => c.id == carreraSeleccionada.id))
            {
                MessageBox.Show("La carrera ya está asignada.");
                return;
            }

            carrerasAsignadas.Add(carreraSeleccionada);

            var newItem = new ListViewItem(carreraSeleccionada.nombre); 
            newItem.Tag = carreraSeleccionada.id; // guardo el id para poder eliminarlo despues
            CarrerasGrpListView.Items.Add(newItem);
        }
        
        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            if (AlumnosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un alumno para eliminar.");
                return;
            }

            var item = AlumnosListView.SelectedItems[0];
            int idAlumno = int.Parse(item.SubItems[0].Text);

            string mensaje = $"Va a eliminar al alumno con ID: {idAlumno}\n" +
                     $"Nombre: {item.SubItems[1].Text}\n" +
                     $"Apellido: {item.SubItems[2].Text}\n" +
                     $"DNI: {item.SubItems[3].Text}\n";

            MessageBox.Show(mensaje, "Verificación antes de eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            try
            {
                bool eliminado = negocio.EliminarAlumnoPorId(idAlumno);
                if (eliminado)
                {
                    MessageBox.Show("Alumno eliminado correctamente.");

                    AlumnosListView.Items.Remove(item);

                    BuscarDniTxb.Text = "";
                    
                    LimpiarCampos();
                    
                    ActivarEdicion(false);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Alumno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Alumno: " + ex.Message);
            }

        }

        private void CancelarGrpBtn_Click(object sender, EventArgs e)
        {
            ActivarEdicion(false);
            LimpiarCampos();
        }

        private void AceptarGrpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposObligatorios()) return;
                if (!ValidarNombreApellido()) return;
                if (!ValidarDni()) return;

                var carrerasIds = carrerasAsignadas.Select(c => c.id).ToList();

                if (carrerasIds.Count == 0)
                {
                    MessageBox.Show("Debe asignar al menos una carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creamos el objeto docente con los datos modificados
                Alumno AlumnoEditado = new Alumno()
                {
                    id = int.Parse(IdGrpTxb.Text),
                    nombre = NombreGrpTxb.Text,
                    apellido = ApellidoGrpTxb.Text,
                    dni = DniGrpTxb.Text,
                    carrerasIds = carrerasIds
                };

                string mensaje = $"ID: {AlumnoEditado.id}\n" +
                         $"Nombre: {AlumnoEditado.nombre}\n" +
                         $"Apellido: {AlumnoEditado.apellido}\n" +
                         $"DNI: {AlumnoEditado.dni}\n" +
                         $"Carreras asignadas: {string.Join(", ", AlumnoEditado.carrerasIds)}";

                MessageBox.Show(mensaje, "Datos a enviar (Edición)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                bool resultado = negocio.EditarAlumno(AlumnoEditado);

                if (resultado)
                {
                    MessageBox.Show("Cambios guardados correctamente.");

                    AlumnosListView.Items.Clear();

                    var item = new ListViewItem(AlumnoEditado.id.ToString());
                    item.SubItems.Add(AlumnoEditado.nombre);
                    item.SubItems.Add(AlumnoEditado.apellido);
                    item.SubItems.Add(AlumnoEditado.dni);


                    AlumnosListView.Items.Add(item);

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

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(NombreGrpTxb.Text) ||
                string.IsNullOrWhiteSpace(ApellidoGrpTxb.Text) ||
                string.IsNullOrWhiteSpace(DniGrpTxb.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarNombreApellido()
        {
            var regex = new System.Text.RegularExpressions.Regex("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$");
            if (!regex.IsMatch(NombreGrpTxb.Text.Trim()) || !regex.IsMatch(ApellidoGrpTxb.Text.Trim()))
            {
                MessageBox.Show("Nombre y Apellido sólo deben contener letras y espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarDni()
        {
            string dni = DniGrpTxb.Text.Trim();
            if (dni.Length != 8)
            {
                MessageBox.Show("El DNI debe contener exactamente 8 números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo debe contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void QuitarGrpBtn_Click(object sender, EventArgs e)
        {
            if (CarrerasGrpListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una carrera para quitar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemSeleccionado = CarrerasGrpListView.SelectedItems[0];
            int idCarrera = (int)itemSeleccionado.Tag;

            CarrerasGrpListView.Items.Remove(itemSeleccionado);

            carrerasAsignadas.RemoveAll(c => c.id == idCarrera);
        }
        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuAdministrador = new MenuAdministrador();
            menuAdministrador.Show();
        }

        
    }
}
