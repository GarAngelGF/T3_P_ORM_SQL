using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Paciente
    {
        public string Nombre { get; set; }
        public string Contacto { get; set; } // Puede ser email o teléfono

        public Paciente(string nombre, string contacto)
        {
            Nombre = nombre;
            Contacto = contacto;
        }
    }
}
