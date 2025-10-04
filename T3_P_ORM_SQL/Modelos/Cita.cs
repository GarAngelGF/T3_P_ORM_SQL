using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Cita
    {
        public DateTime FechaHora { get; set; }
        public Doctor MedicoAsignado { get; set; }
        public Paciente PacienteInfo { get; set; } // Cambiado a PacienteInfo
        public string Motivo { get; set; }

        // Propiedades para mostrar en la tabla
        public string Hora => FechaHora.ToString("HH:mm");
        public string NombreMedico => MedicoAsignado?.Nombre;
        public string NombrePaciente => PacienteInfo?.Nombre;

        public Cita(DateTime fechaHora, Doctor medico, Paciente paciente, string motivo)
        {
            FechaHora = fechaHora;
            MedicoAsignado = medico;
            PacienteInfo = paciente;
            Motivo = motivo;
        }
    }
}
