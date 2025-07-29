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
        public string _profesorNombre;
        public List<string> _dias;
        public List<Horario> _horarios;
        public List<int> _idDocentes;

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
        public List<int> idDocentes
        {
            get { return _idDocentes; }
            set { _idDocentes = value; }
        }
    }
}
