using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CursoResumenDTO
    {
        public int _id;
        public String _profesorNombre;
        public List<string> _dias;
        public List<Horario> _horarios;
        public List<int> _idDocente;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string profesorNombre
        {
            get { return _profesorNombre; }
            set { _profesorNombre = value; }
        }
        public List<string> dias
        {
            get { return _dias; }
            set { _dias = value; }
        }
        public List<Horario> horarios
        {
            get { return _horarios; }
            set { _horarios = value; }
        }
        public List<int> idDocente
        {
            get { return _idDocente; }
            set { _idDocente = value; }
        }
    }
}
