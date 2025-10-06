using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using T3_P_ORM_SQL.Modelos;
using T3_P_ORM_SQL.Vistas.Citas_Crud;

namespace T3_P_ORM_SQL.Controladores
{
    internal class CitasController<Tform> where Tform : Form
    {
        private readonly Tform _form;
        private readonly BindingSource vercitasBindinSource;
        private readonly BindingSource verdoctoresBindinSource;
        private readonly BindingSource verpacientesBindinSource;
        private readonly BindingSource verhorarioBindinSource;
        private readonly Contextobd contextobd;

        public CitasController(Tform tform ,Contextobd contextobd) 
        {
            this.contextobd = contextobd;
            this._form = tform; 
            this.vercitasBindinSource = new BindingSource();
            this.verdoctoresBindinSource = new BindingSource();
            this.verpacientesBindinSource = new BindingSource();
            this.verhorarioBindinSource = new BindingSource();
        }

        public BindingSource OnVerCitas() 
        {
            var Citas = contextobd.Citas
                .Include(c => c.DoctorCitas)
                    .ThenInclude(dc => dc.Doctor)
                .Select(c => new
                {
                    IdDeLaCita = c.Id,
                    IdDelPaciente = c.PacienteCitas.Select(pc => pc.Paciente.Id).FirstOrDefault(),
                    IdDelMedico = c.DoctorCitas.Select(pc => pc.Doctor.Id).FirstOrDefault(),
                    Fecha = c.FechaHora,
                    MotivoCita = c.Motivo,
                    NombreDelDoctor = c.DoctorCitas.Select(dc => dc.Doctor.Nombre).FirstOrDefault(),
                    NombreDelPaciente = c.PacienteCitas.Select(pc => pc.Paciente.Nombre).FirstOrDefault()
                })
                .ToList();
            vercitasBindinSource.DataSource = Citas;
            return vercitasBindinSource;
        }
        public BindingSource OnCargarDoctor()
        {
            var Doctor = contextobd.Doctores
                .ToList();
           verdoctoresBindinSource.DataSource = Doctor;
            return verdoctoresBindinSource;
        }

        public BindingSource ONCargarPaciente()
        {
            var pacientes = contextobd.Pacientes
                .ToList();
            verpacientesBindinSource.DataSource = pacientes;
            return verpacientesBindinSource;
        }

        public BindingSource OnCargarHorario()
        {
            var horariosDisponibles = new List<string>();
            for (int hora = 9; hora < 19; hora++)
            {
                horariosDisponibles.Add($"{hora:00}:00");
                horariosDisponibles.Add($"{hora:00}:30");
            }

            verhorarioBindinSource.DataSource = horariosDisponibles;

            return verhorarioBindinSource;
        }

        public bool OnValidarConflicto(Doctor doctor, DateTime Fechayhoraseleccionada)
        {
            int idDelDoctor = doctor.Id;

            bool HayConflicto = contextobd.Citas.Include(dc => dc.DoctorCitas).Any(c => c.FechaHora == Fechayhoraseleccionada && c.DoctorCitas.Any(dc => dc.DoctorId == idDelDoctor));

            return HayConflicto;
                
        }

        public bool OnNoCitaPrevia(Paciente paciente, DateTime Fechayhoraseleccionada)
        {
            int idDelPaciente = paciente.Id;

            bool HayConflicto = contextobd.Citas
                .Include(dc => dc.PacienteCitas)
                .Any(c => c.FechaHora == Fechayhoraseleccionada &&
                          c.PacienteCitas.Any(dc => dc.PacienteId == idDelPaciente));
            return HayConflicto;
        }

        public void OnAgendarCitas(Doctor doctor, Paciente paciente, DateTime Fechayhoraseleccionada, string motivo)
        {
            if (OnValidarConflicto(doctor, Fechayhoraseleccionada))
            {
                MessageBox.Show($"El Dr. {doctor.Nombre} ya tiene una cita programada en esa fecha y hora.", "Conflicto de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (OnNoCitaPrevia(paciente, Fechayhoraseleccionada))
            {
                MessageBox.Show($"El paciente {paciente.Nombre} ya tiene una cita programada en esa fecha y hora.", "Conflicto de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            var nuevaCita = new Cita
            {
                FechaHora = Fechayhoraseleccionada,
                Motivo = motivo,
                DoctorCitas = new List<Inter_Doc_Cita>
                {
                    new Inter_Doc_Cita { Doctor = doctor } 
                },
                PacienteCitas = new List<Inter_Paciente_Cita>
                {
                    new Inter_Paciente_Cita { Paciente = paciente } 
                }
            };

            contextobd.Citas.Add(nuevaCita);
            contextobd.SaveChanges();

            MessageBox.Show("Cita agendada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void OnModificar(Cita cita, Doctor doctor, Paciente paciente)
        {
            
            if (OnValidarConflicto(doctor, cita.FechaHora))
            {
                MessageBox.Show($"El Dr. {doctor.Nombre} ya tiene una cita programada en esa fecha y hora.", "Conflicto de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (OnNoCitaPrevia(paciente, cita.FechaHora))
            {
                MessageBox.Show($"El paciente {paciente.Nombre} ya tiene una cita programada en esa fecha y hora.", "Conflicto de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contextobd.Citas.Update(cita);
            contextobd.SaveChanges();

            MessageBox.Show("Cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
