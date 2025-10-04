using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Cita
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }

        // Clave foránea para Doctor
        public int MedicoAsignadoId { get; set; }
        [ForeignKey("MedicoAsignadoId")]
        public virtual Doctor MedicoAsignado { get; set; }

        // Clave foránea para Paciente
        public int PacienteInfoId { get; set; }
        [ForeignKey("PacienteInfoId")]
        public virtual Paciente PacienteInfo { get; set; }

        // Propiedades para mostrar en la tabla que no se mapean
        [NotMapped]
        public string Hora => FechaHora.ToString("HH:mm");
        [NotMapped]
        public string NombreMedico => MedicoAsignado?.Nombre;
        [NotMapped]
        public string NombrePaciente => PacienteInfo?.Nombre;

        // Constructor vacío requerido por EF Core
        public Cita() { }

        public Cita(DateTime fechaHora, Doctor medico, Paciente paciente, string motivo)
        {
            FechaHora = fechaHora;
            MedicoAsignado = medico;
            PacienteInfo = paciente;
            Motivo = motivo;
        }
    }
}
