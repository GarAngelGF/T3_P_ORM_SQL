using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Paciente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; } // Puede ser email o teléfono

        // Propiedad de navegación para las citas
        public virtual ICollection<Cita> Citas { get; set; }

        // Constructor vacío requerido por EF Core
        public Paciente() { }

        public Paciente(string nombre, string contacto)
        {
            Nombre = nombre;
            Contacto = contacto;
        }
    }
}
