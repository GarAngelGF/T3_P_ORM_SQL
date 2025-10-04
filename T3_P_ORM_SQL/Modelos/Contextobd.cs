using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace T3_P_ORM_SQL.Modelos
{
    internal class Contextobd : DbContext
    {
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Aquí defines la cadena de conexión a tu archivo de base de datos SQLite
            optionsBuilder.UseSqlite("Data Source=T3_P_ORM_SQL.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Opcional: Configuraciones adicionales del modelo (Fluent API)
            // Por ejemplo, para definir relaciones explícitamente si no usas atributos
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.MedicoAsignado)
                .WithMany(d => d.Citas)
                .HasForeignKey(c => c.MedicoAsignadoId);

            modelBuilder.Entity<Cita>()
                .HasOne(c => c.PacienteInfo)
                .WithMany(p => p.Citas)
                .HasForeignKey(c => c.PacienteInfoId);
        }
    }
}
