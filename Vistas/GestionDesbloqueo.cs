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

namespace Vistas
{
    public partial class GestionDesbloqueo : Form
    {
        
        public GestionDesbloqueo()
        {
            InitializeComponent();
        }

        private void DesbloquearBtn_Click(object sender, EventArgs e)
        {
            DesbloquearUsuarioRequest desbloquearUsuarioRequest = new DesbloquearUsuarioRequest();


        }
    }
}
