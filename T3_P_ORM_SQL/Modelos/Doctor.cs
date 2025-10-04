using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Doctor
    {
        // 1. Añadimos las propiedades que antes heredaba
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }

        // 2. Mantenemos las propiedades que ya eran suyas
        public string NumeroLicencia { get; set; }

        // 3. La propiedad para el ComboBox sigue siendo muy útil
        public string DisplayText => string.IsNullOrWhiteSpace(Especialidad) || Especialidad == "Médico General"
                                    ? Nombre
                                    : $"{Nombre} - {Especialidad}";

        public override string ToString()
        {
            // Forzamos a que devuelva el DisplayText que ya creamos
            return this.DisplayText;
        }

        // 4. Actualizamos los constructores para que asignen los valores directamente
        public Doctor(string rfc, string nombre, string telefono, string especialidad, string numeroLicencia)
        {
            this.Rfc = rfc;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Especialidad = especialidad;
            this.NumeroLicencia = numeroLicencia;
        }

        public Doctor(string rfc, string nombre, string telefono, string numeroLicencia)
        {
            this.Rfc = rfc;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Especialidad = "Médico General";
            this.NumeroLicencia = numeroLicencia;
        }
    }
}
