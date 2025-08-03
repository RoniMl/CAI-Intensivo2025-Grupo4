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
using Vistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAI_Intensivo2025_Grupo4.Vistas
{
    public partial class LiquidacionSueldo : Form
    {
        public MenuPersonalNegocio menuPersonalNegocio = new MenuPersonalNegocio();
        public LiquidarNegocio liquidarNegocio = new LiquidarNegocio();


        public Docente docente;
        public DocenteLiquidacion resultadoLiquidacion;

        public LiquidacionSueldo(Docente docenteLogueado)
        {
            InitializeComponent();
            this.docente = docenteLogueado;
        }

        public void LiquidacionSueldo_Load(object sender, EventArgs e)
        {
            var liquidarNegocio = new LiquidarNegocio();
            resultadoLiquidacion = liquidarNegocio.LiquidarDocente(docente);

            CargarEnListView(resultadoLiquidacion);

        }

        private void CargarEnListView(DocenteLiquidacion doc)
        {
            liquidacionList.Items.Clear();
            ListViewItem item = new ListViewItem(resultadoLiquidacion.nombre);
            item.SubItems.Add(doc.apellido);
            item.SubItems.Add(doc.cuit);
            item.SubItems.Add(doc.horasTotales.ToString());
            item.SubItems.Add(doc.sueldo.ToString("C"));
            liquidacionList.Items.Add(item);
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPersonal menuPersonal = new MenuPersonal(docente.id);
            menuPersonal.Show();            
        }

    }
}
