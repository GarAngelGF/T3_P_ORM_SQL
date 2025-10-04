using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }
        public string NumeroLicencia { get; set; }

        // Propiedad de navegación para las citas
        public virtual ICollection<Cita> Citas { get; set; }

        [NotMapped] // Esta propiedad no se mapeará a la base de datos
        public string DisplayText => string.IsNullOrWhiteSpace(Especialidad) || Especialidad == "Médico General"
                                    ? Nombre
                                    : $"{Nombre} - {Especialidad}";

        public override string ToString()
        {
            return this.DisplayText;
        }

        // Constructor vacío requerido por EF Core
        public Doctor() { }

        public Doctor(string rfc, string nombre, string telefono, string especialidad, string numeroLicencia)
        {
            this.Rfc = rfc;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Especialidad = especialidad;
            this.NumeroLicencia = numeroLicencia;
        }
    }
}
