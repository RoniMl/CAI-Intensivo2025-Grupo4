using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DesbloquearUsuarioRequest
    {
        int _idUsuario { get; set; }

        public int idUsuario
        {
            get => _idUsuario;
            set => _idUsuario = value;
        }
    }
}
