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
        private long idDocente;
        public MenuPersonal(long idDocente)
        {
            InitializeComponent();
            this.idDocente = idDocente;

            LiquidarBtn.Click += LiquidarBtn_Click;
            this.idDocente = idDocente;
        }

        private void LiquidarBtn_Click(object? sender, EventArgs e)
        {
            if (idDocente.TipoDocente == "AYUDANTE_AD_HONOREM")
            {
                MessageBox.Show("No es posible liquidar el sueldo. El docente es Ad Honorem.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar el formulario de liquidación si no es ad honorem
            var form = new LiquidacionSueldo(idDocente);
            form.Show();
        }
    }
}
