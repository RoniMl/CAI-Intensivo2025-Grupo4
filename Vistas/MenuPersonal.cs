using CAI_Intensivo2025_Grupo4.Vistas;
using Datos;
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
    public partial class MenuPersonal : Form
    {


        public int idDocente;
        public MenuPersonal(int idDocente)
        {
            InitializeComponent();
            this.idDocente = idDocente;
            LiquidarBtn.Click += LiquidarBtn_Click;            
        }

        private void LiquidarBtn_Click(object? sender, EventArgs e)
        {
            // Mostrar el formulario de liquidación si no es ad honorem



            var form = new LiquidacionSueldo();
            form.Show();
        }
    }
}
