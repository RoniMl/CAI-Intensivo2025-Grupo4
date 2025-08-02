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
using Datos;

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class GenerarReportes : Form
    {
        GenerarReportesNegocio generarReportesNegocio = new GenerarReportesNegocio();
        public GenerarReportes()
        {
            InitializeComponent();
        }

        private void GenerarReportes_Load(object sender, EventArgs e)
        {

        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            List<MateriaReporte> reportes = generarReportesNegocio.generarReportes();
            reporteListView.Items.Clear();

            foreach (var reporte in reportes)
            {
                ListViewItem item = new ListViewItem(reporte.nombre);
                item.SubItems.Add(reporte.cumLaude.ToString());
                item.SubItems.Add(reporte.magnumSummaCumLaude.ToString());
                item.SubItems.Add(reporte.summaCumLaude.ToString());
                item.SubItems.Add(reporte.totalEgresados.ToString());
                reporteListView.Items.Add(item);
            }
        }

        private void Atrasbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menuAdmin = new MenuAdministrador();
            menuAdmin.Show();
            
        }
    }
}
