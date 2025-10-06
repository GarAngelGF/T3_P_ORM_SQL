using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3_P_ORM_SQL.Controladores;
using T3_P_ORM_SQL.Modelos;

namespace T3_P_ORM_SQL.Vistas.Citas_Crud
{
    public partial class Citas_Modificar : Form
    {
        private readonly CitasController<Citas_Modificar> controller;
        private readonly Contextobd contextobd;
        internal Citas_Modificar(Contextobd contexto)
        {
            InitializeComponent();
            this.contextobd = contexto;
            controller = new CitasController<Citas_Modificar>(this, contextobd);
        }

        public void VerCitas()
        {
            DgvCitas.DataSource = controller.OnVerCitas();
        }

        private void Citas_Modificar_Load(object sender, EventArgs e)
        {
            VerCitas();
            CargarDoctor();
            CargarPaciente();
            CargarHorario();
            DesabilitarControles(false, CmbDoctor, CmbPaciente, CmbHorario, textBox1, BtnGuardar, BtnCancelar);
        }

        private void DesabilitarControles(bool habilitar, params Control[] controles)
        {
            foreach (var control in controles)
            {
                control.Enabled = habilitar;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvCitas.Rows.Count < 0)
            {
                MessageBox.Show($"Debe de seleccionar una cita primero", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dynamic citaSeleccionada = DgvCitas.CurrentRow.DataBoundItem;
                DateTime Hora = citaSeleccionada.Fecha;
                string horaFormateada = Hora.ToString("HH:mm");

                CmbDoctor.SelectedValue = citaSeleccionada.IdDelMedico;
                CmbHorario.Text = horaFormateada;
                CmbPaciente.SelectedValue = citaSeleccionada.IdDelPaciente;
                textBox1.Text = citaSeleccionada.MotivoCita;

                DesabilitarControles(true, CmbDoctor, CmbPaciente, CmbHorario, textBox1, BtnGuardar, BtnCancelar);
                DesabilitarControles(false, BtnModificar);
            }
        }

        private void CargarDoctor()
        {
            CmbDoctor.DataSource = controller.OnCargarDoctor();
            CmbDoctor.DisplayMember = "DisplayText";
            CmbDoctor.ValueMember = "Id";
        }

        private void CargarPaciente()
        {
            CmbPaciente.DataSource = controller.ONCargarPaciente();
            CmbPaciente.DisplayMember = "Nombre";
            CmbPaciente.ValueMember = "Id";
        }

        private void CargarHorario()
        {
            CmbHorario.DataSource = controller.OnCargarHorario();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            dynamic citaSeleccionada = DgvCitas.CurrentRow.DataBoundItem;
            DateTime Hora = citaSeleccionada.Fecha;
            DateTime fechaYHoraDeLaCita = DateTime.Now ;
            var comboBox = CmbDoctor as ComboBox;
            var comboBox1 = CmbPaciente as ComboBox;

            if (comboBox == null && comboBox1 == null)
            {
                return;
            }

            Doctor doctorSeleccionado = comboBox.SelectedItem as Doctor;

            Paciente pacienteSeleccionado = comboBox1.SelectedItem as Paciente;

            string horaTexto = CmbHorario.Text;
            if (string.IsNullOrWhiteSpace(horaTexto)) return;
            string Motivo = textBox1.Text;
            if (string.IsNullOrEmpty(Motivo)) return;

            if (TimeSpan.TryParse(horaTexto, out TimeSpan horaseleecionada))
            {
                fechaYHoraDeLaCita = Hora + horaseleecionada;
            }

            var nuevaCita = new Cita
            {
                Id = citaSeleccionada.IdDeLaCita,
                FechaHora = fechaYHoraDeLaCita,
                Motivo = Motivo,
                DoctorCitas = new Inter_Doc_Cita[]
                {
                    new Inter_Doc_Cita { Doctor = doctorSeleccionado, DoctorId = doctorSeleccionado.Id, CitaId = citaSeleccionada.IdDeLaCita }
                },
                PacienteCitas = new Inter_Paciente_Cita[]
                {
                    new Inter_Paciente_Cita { Paciente = pacienteSeleccionado }
                }
            };

            controller.OnModificar(nuevaCita, doctorSeleccionado, pacienteSeleccionado);
        }
    }
}
